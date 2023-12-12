# GitHub Copilot - Your AI-Powered Coding Assistant

GitHub Copilot is an innovative coding assistant powered by machine learning that helps you write code faster and with less effort. This README provides an overview of GitHub Copilot's features and guides you through the process of getting started with it using Visual Studio Code.

## Section 1: Introduction & Features for GitHub CoPilot

GitHub Copilot is designed to enhance your coding experience with the following key features:

- **Code Autocompletion:** Copilot suggests whole lines or blocks of code as you type, saving you time and effort.
- **Natural Language Understanding:** Write code in plain English comments, and Copilot intelligently generates corresponding code snippets.
- **Extensive Language Support:** Supports multiple programming languages, making it versatile for various development tasks.

## Section 2: Prerequisites for using GitHub Copilot

Before diving into GitHub Copilot, ensure you have the following prerequisites:

- **Visual Studio Code:** GitHub Copilot is tightly integrated with VS Code, so make sure you have it installed.
- **GitHub Account:** Sign in to VS Code using your GitHub account for a seamless experience.

## Section 3: Getting Started with GitHub CoPilot with VS Code

To start using GitHub Copilot in Visual Studio Code, follow these steps:

- Install the GitHub Copilot extension from the VS Code marketplace.
- Sign in to your GitHub account within VS Code.
- Open a code file, and start coding! Copilot will provide suggestions as you type.
- Accessing Azure Key Vault and Azure Cosmos DB required to successfully run the final program. Refer to:

- ![GitHub CoPilot presentation](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/blob/main/docs/MicrosoftDeveloperExperienceDay.GhCopilot.pdf), and, 
- ![GitHub CoPilot sample REST Azure Function source](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/blob/main/src/MyHttpTrigger.cs)

for addtional information and final code sample. 

### Interacting with GitHub CoPilot is available via three options: 

- Option 1: GitHub CoPilot Chat extension, avaialabe on the VS Code **activity bar**
- Option 2: Right-click within a file, or code, select the menu **CoPilot->Start inline chat** item, or, **Ctrl+I**
- Option 3: Start writing a comment **// how do I create a comment in dotnet**, **enter** or **tab** to see or accept recommendations. 

| CoPilot Chat Extension | CoPilot Inline Chat | CoPilot Comment Style |
| :-: | :-: | :-: |
| ![GHCoPilotVSCodeExtensionChat](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/2949217b-8beb-41f7-aea6-ce12d0f6fc2a) | ![GHCoPilotVSCodeInlineChat](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/ac5341b6-1153-4249-9a91-0ae8ddc56242) | **Start typing a comment in code, tab or enter** |

### Using the GitHub Copilot "Chat" prompt extension, here are a few suggested dialog prompts to launch your discovery: 

``` 
What azure service is recommended to create a REST endpoint for connecting to Cosmos Db 
```

```
What vs code extentions are required to create an azure function and run with local storage for testing
```

```
What .net packages are required to run a function in azure, access keyvault and connect to cosmos db
```

```
What .net using statements are required for an http post, access keyvault and connect to cosmos db
```

```
How do I create an azure http request .net function in visual studio code
```

```
What dotnet commands are required to create an azure http function
```

**Here's an example using the VS Code GitHub CoPilot chat interface** 

![GitHub Copilot Chat sample prompt dialog](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/74eef4e8-e718-44de-b6e3-613194e7d362)

## Section 4: Creating an Azure Function with GitHub CoPilot and VS Code

Learn how to create an Azure Function using GitHub Copilot and Visual Studio Code with the following steps:

1. Install the required Azure extensions in VS Code. **Ask CoPilot how**
2. Create a new file or project for your Azure Function.
3. Recommended: use the VS Code **builtin** Azure Function create dialog.

![VS Code Azure Function create dialog](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/80078f7d-2399-4524-b252-9c6b0fe56ad1)

4. Optionally: use VS Code **Terminal** & create the function with **dotnet func** commands
   
```bash
#
# Sample func init command in VS Code Terminal to create
# a new Azure function in CWD, using Azure Function Core V4 
$PS1> func init MyHttpFunction --dotnet  --AzureFunctionsVersion v4
$PS1 cd MyHttpFunction 
$PS1> func new --name MyHttpTrigger --template "HTTP trigger" --authlevel "anonymous"
```

![VSCode CreateFunction FunctionInit](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/ecc26dd1-ca3b-4abb-b616-2a682de8a343)

Now, let's get started using Copilot to speed up your discovery!

## Section 5 Overview: GitHub Copilot Prompts to verify REST POST properties

Copilot seamlessly integrates with Azure services. Follow suggested prompt & flow to build something **fun**. 

1. Open the desired file or project.
2. Use Copilot to generate code snippets for steps.
3. Customize the generated code based on your specific configurations.
4. Prompts & instructions are intended as a **guide**, not a step-by-step **tutorial**. The intent is to **discover** & **explore** features and familarity with GitHub CoPilot. 

**NOTE:** CoPilot interacts with the code using current context and style, therefore, consistency in prompt dialog helps CoPilot achieve the desired patterns. 

<img src="https://github.com/images/modules/site/copilot/productivity-bg-head.png" width="100" height="100">  **Ultimately, the developer is pilot-in-command, PIC**, therefore applying logic and thought to the desired outcome is **REQUIRED** before accepting code suggestions.

## Section 5a: Start prompting CoPilot to verify **POST** query & request header properties 

1. Open the **MyHttpFunction** project in VS Code, and start with a clean pallete, in other words: **DELETE** the generated function code **EXCEPT** initial method header and using statements. Optionally, run the empty function and test locally to verify a starting point. **Ask Copilot** 
   
![MyHttpFunction CleanPallette](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/2c5b74fe-48ec-457d-8399-e7b20ca4d5a5)

3. Start off by verifying parameters & properties in the **POST**, thence, run a local test

``` // verify that the B2BCustomerId is not null and return a 400 if it is null ``` 

``` // insert a 200 response and include the B2BCustomerId in the response body ```

Moving back after the **verification of B2BCustomerId** stanza, let's add some checks for other data. **tab** or **accept** as CoPilot prompts 

``` // read request header and verify the B2BCustomerIdKey is not null, if null return unauthorized``` 

``` // deserialize the request body to a dynamic object```

``` // verify the data object includes an OrderId, OrderDateTime, CustomerId, and OrderId and if not return BadRequestBody```

At this point, you should be getting the flow and interaction with CoPilot: 

- adding a comment, view recommendations 
- inspecting the recommendations
- accepting or trying again
- we'll see what the code looks like momentarily for this first section. 

Generate a unique id for later, therefore, let's use CoPilot to generate and log what we have so far

``` // create a uuid and add to data.id```

``` // send requestBody the log in the format of RequestBody: {requestBody}```

``` // send data object ot the log in the format of Data: {data}```

### Save our progress, and, try to run the program with VS Code. (snip below)

- Use CoPilot to assist!
- If extensions are missing use the CoPilot Chat dialog to help resolve any missing extensions, or references
- Install extensions, or add missing **using** statements, stop and restart VS Code
  
![Step5a SampleCodeSnip](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/0cbff455-c064-4f80-9c8b-8f431f583619)

## Section 6: GitHub Copilot prompts to connect and access an Azure Key Vault secret

**NOTE:** Inspect the recommendations as generated by CoPilot. The prompt/response model requires some insight here, may need to add **using <name>** statements, or add **dotnet packages** 

``` // create a connection to Azure Key Vault with DefaultAzureCredential and return server error 500 if unable to connect``` 

Using **GetSecretAsync** in the comment to help Copilot come to the correct recommendation 

``` // verify a secretValue with GetSecretAsync and return server error 500 if unable to get secret```

``` // assign the secretValue to a variable ```

**CAUTION:** Do **NOT** send secrets to the log, let's truncate, or better yet, let CoPilot help us **mask** the string 

``` // send secretValue to the log in the format of SecretValue: {secretValue}, truncate the secretValue to 5 characters```

``` // send secretValue to the log in the format of SecretValue: {secretValue}, mask after the string "AccountKey=" ```

### Save our progress, configure Azure Key Vault RBAC controls, thence to run the program with VS Code. 

![Section 6, Azure Key Vault](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/be0d8797-b945-4feb-b189-25fc622d2b49)

### Azure Key Vault RBAC controls (local) or Azure Function integration 

Enable **authentication** and **authorization** for the **Function instance** to 1: Access Azure Key Vault, and, 2: **read** a secret

- **Azure Function instance** must run using a **credential** defined in Azure (Entra) Active Directory (user principal, user assigned, or system assigned identity)
- Configure Azure Key Vault RBAC controls to allow **Key Vault Secrets User** for intended secret (**Ask CoPilot** how to do this)
  
Refer to ![Azure Key Vault Grant Permissions documentation](https://learn.microsoft.com/en-us/azure/key-vault/general/rbac-guide?tabs=azure-cli)


## Section 7: GitHub Copilot prompts to connect to Azure Cosmos DB and send data 

### Connection to Azure Cosmos DB requires an instance of Cosmos DB, Container, and credentials 

Refer to the following article for creating, configuring and connecting to Cosmos DB. ![Connect to Azure Cosmos DB quick start](https://learn.microsoft.com/en-us/azure/cosmos-db/nosql/how-to-dotnet-get-started?tabs=azure-cli)

**NOTE:** Inspect the recommendations as generated by CoPilot. The prompt/response model requires some insight here, may need to add **using <name>** statements, or add **dotnet packages** 

By now, you should be getting the hang of interacting with CoPilot, try a few more hints. 

``` // Create CosmosDB client connection using the secretValue as the connection string if unable to connect return server error 500```

``` // Connect to Cosmos DB and create a database if unable to connect return server error 500 ```

``` // Connect to Cosmos DB container and if unable to connect return server error 500```

``` // try to send data object to DemoOrderItemsContainer and if it fails return a 500 error ```

``` // insert a 200 return statement and return the B2BCustomerId. the OrderId and DataId```

**NOTE:** If VS Code is not able to build the program.cs due to errors, navigate to the **PROBLEMS** tab in VS Code, right-click on the error and **Explain using CoPilot** 

![MissingDirectivesNamespaceErrors](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/ef193269-d3d5-40ce-82ad-d6bbb861fb84)

### Save our progress, build and run the program with VS Code. If Azure Key Vault Secret and Azure Cosmos DB services are configured, use your favorite REST Client to test. 

Sample REST POST request syntax: 

``` http://localhost:7071/api/MyHttpTrigger1?B2BCustomerId=27330 ```

Sample REST POST request header: 

``` B2BCustomerIdKey: 27330Key```


Sample REST POST request JSON body: 
```
{
 "OrderId": 123456789,
 "OrderDateTime": "2023-11-30T13:07:01.001Z",
 "CustomerId": "Az0123456789",
 "ProductId": "Prod0123456789"
 }
```

## Finally, a few closing thoughts for completeness 

- Ask CoPilot to find out how to move the string variables in the program to an **appsettings.json** file. This will result in better style and formatting
- Ask CoPilot how to move the Azure Key Vault method to connect using the default credential to a static function. This will improve initialization and performance.
- Ask Copilot how to create a method and move the AzureKeyVaultConnect and AzureCosmosDbConnect sections into seperate files.
## Section 8: 
- Sample ![MyHttpTrigger.cs complete sample](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/blob/main/src/MyHttpTrigger.cs)
- Sample ![MyHttpFunction Git Repo](https://github.com/garyciampa/MyHttpFunction)

## Section 8: 

GitHub Copilot revolutionizes the way we write code, making development more efficient and enjoyable. Experiment with Copilot in various scenarios, explore its capabilities, and enhance your coding productivity.

Feel free to share your experiences, report issues, or contribute to the GitHub Copilot community.

Happy coding!
