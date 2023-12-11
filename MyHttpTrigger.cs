using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Cosmos;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace Contoso.Function  
{
    public static class MyHttpTrigger
    {
        [FunctionName("HttpTrigger1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

        // verify the query parameter B2BCustomerId is not null and return a 400 if it is null 
            string B2BCustomerId = req.Query["B2BCustomerId"];
            if (B2BCustomerId == null)
            {
                return new BadRequestObjectResult("Please pass a B2BCustomerId on the query string");
            }

        // read request header and verify the B2BCustomerIdKey is not null, if null return unquthorized 401
            string B2BCustomerIdKey = req.Headers["B2BCustomerIdKey"];
            if (B2BCustomerIdKey == null)
            {
                return new UnauthorizedResult();
            }

        // deserialize the request body to a dynamic object 
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

        // verify the data object includes an OrderId, OrderDateTime, CustomerId, and OrderId and if not return BadRequestBody
            if (data.OrderId == null || data.OrderDateTime == null || data.CustomerId == null || data.OrderId == null)
            {
                return new BadRequestObjectResult("Please pass an OrderId, OrderDateTime, CustomerId, and OrderId in the request body");
            }

            // create a uuid and add to data.id
            data.id = Guid.NewGuid();

            // send requestBody the log in the format of RequestBody: {requestBody}
            log.LogInformation($"RequestBody: {requestBody}");
            // send data object ot the log in the format of Data: {data}
            log.LogInformation($"Data: {data}");

		// create a connection to Azure Key Vault with DefaultAzureCredential and return 500 error and message if unable to connect
            var kvUri = "https://kv-ade-useast2-001.vault.azure.net/";
            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            if (client == null)
            {
                return new ObjectResult("Unable to connect to Azure Key Vault") { StatusCode = 500 };
            }
        
        // verify a secretValue with getsecretasync and return server error 500 if unable to get secret
            KeyVaultSecret secret = await client.GetSecretAsync("CosmosDbDemoOrderItems");
            if (secret == null)
            {
                return new ObjectResult("Unable to get secret") { StatusCode = 500 };
            }

        // assign the secretValue to a variable
            string secretValue = secret.Value;

        // send the secretValue to the log in the format of SecretValue: {secretValue} and truncate the secretValue to 5 characters
            log.LogInformation($"SecretValue: {secretValue.Substring(0, 5)}");

        // send the secretValue to the log in the format of SecretValue: {secretValue}, and mask after the string "AccountKey=" 
            log.LogInformation($"SecretValue: {secretValue.Substring(0, secretValue.IndexOf("AccountKey=") + 11)}**********");

        // create CosmosDb Client connection with the secretValue as the connection string
            CosmosClient cosmosClient = new CosmosClient(secretValue);
        // if unable to connect to CosmosDb return a 500 error and message
            if (cosmosClient == null)
            {
                return new ObjectResult("Unable to connect to CosmosDb") { StatusCode = 500 };
            }

        // Connect to Cosmos DB using cosmosClient and return server error 500 unable to connect to CosmosDB
            Database database = await cosmosClient.CreateDatabaseIfNotExistsAsync("DemoOrderItemsDb");
            if (database == null)
            {
                return new ObjectResult("Unable to connect to CosmosDb") { StatusCode = 500 };
            }

        // Connect to Cosmos DB container and if unable to connect return server error 500 unable to connect to CosmosDB using data.OrderId as the partition key
            Container container = await database.CreateContainerIfNotExistsAsync("DemoOrderItems", "/OrderId");
            if (container == null)
            {
                return new ObjectResult("Unable to connect to CosmosDb Container") { StatusCode = 500 };
            }

        // try to send "data" object to CosmosDB Container
            try
            {
            await container.CreateItemAsync(data);
                return new OkObjectResult("Data sent to Cosmos DB successfully, item id: " + data.id + "");
            }   
        // if unable to send "data" object to CosmosDB Container return server error 500 unable to send data to CosmosDB
            catch (Exception ex)
            {
            log.LogError($"Error sending data to Cosmos DB: {ex.Message}");
            return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }


            // insert a 200 return statement and return the B2BCustomerId. the OrderId and DataId  
            string responseMessage = $"B2BCustomerId: {B2BCustomerId}, OrderId: {data.OrderId}, DataId: {data.id}";
            return new OkObjectResult(responseMessage);

        }
    }
}