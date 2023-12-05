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

1. Install the GitHub Copilot extension from the VS Code marketplace.
2. Sign in to your GitHub account within VS Code.
3. Open a code file, and start coding! Copilot will provide suggestions as you type.

### Using the GitHub Copilot "Chat" prompt dialog, here are a few suggested dialog prompts to launch your discovery: 

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
2. Open a new file or project for your Azure Function.
3. Optionally: use VS Code **Terminal** & create the function with **dotnet func** commands; Or, using the VS Code Azure Function **create** dialog: 
   
```bash
#
# Sample func init command in VS Code Terminal to create
# a new Azure function in CWD, using Azure Function Core V4 
$PS1> func init MyHttpFunction --dotnet  --AzureFunctionsVersion v4
$PS1 cd MyHttpFunction 
$PS1> func new --name MyHttpTrigger --template "HTTP trigger" --authlevel "anonymous"
```

4.  Recommended: use the VS Code **builtin** Azure Function create dialog

![VS Code Azure Function create dialog](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/80078f7d-2399-4524-b252-9c6b0fe56ad1)

5. Optionally, create the desired function using VS Code terminal with **func init** command style

![VSCode CreateFunction FunctionInit](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/ecc26dd1-ca3b-4abb-b616-2a682de8a343)

8. Now, let's get started using Copilot to speed up your discovery!

## Section 5: GitHub Copilot Prompts for VS Code to connect to Azure Key Vault & Azure Cosmos DB

Copilot seamlessly integrates with Azure services. Follow these suggested prompt and flow to build something **fun**. 

1. Open the desired file or project.
2. Use Copilot to generate code snippets for connecting to Azure Key Vault and Cosmos DB.
3. Customize the generated code based on your specific configurations.

**NOTE:** CoPilot interacts with the code using current context and style, therefore, consistency in prompt dialog helps CoPilot achieve the desired patterns. 

**Ulitmately, the developer is pilot-in-command, PIC**, therefore applying logic and thought to the desired outcome is **REQUIRED** before accepting code suggestions

## Section 5a: Lets prompt copilot to verify **POST** query & request header properties 

1. Open the **MyHttpFunction** project in VS Code, and start with a clean pallete, in other words, let's delete the function except for initial method header and using statements. Optionally, run the empty function and test locally to verify a starting point. **Ask Copilot** 
   
![MyHttpFunction CleanPallette](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/2c5b74fe-48ec-457d-8399-e7b20ca4d5a5)

3. Let's start off by verifying parameters & properties in the **POST**, thence, run a local test

**NOTE, CAUTION**: As CoPilot is a context sensitive service, review, accept, copy or tab through suggestion code recommendations and accept as desired

``` // verify that the B2BCustomerId is not null and return a 400 if it is null ``` 

``` // insert a 200 response and include the B2BCustomerId in the response body ```

Moving back after the **verification of B2BCustomerId** stanza, let's add some checks for other data. **tab** or **accept** as CoPilot prompts 

``` // read request header and verify the B2BCustomerIdKey is not null, if null return unquthorized``` 

``` // deserialize the request body to a dynamic object```

``` // verify the data object includes an OrderId, OrderDateTime, CustomerId, and OrderId and if not return BadRequestBody```

At this point, you should be getting the flow and interaction with CoPilot: 

- adding a comment, view recommendations 
- inspecting the recommendations
- accepting or trying again
- we'll see what the code looks like momentarily for this first section. 

We need to generate a unique id for later, therefore, let's use CoPilot to generate and log what we have so far

``` // create a uuid and add to data.id```

``` // send requestBody the log in the format of RequestBody: {requestBody}```

``` // send data object ot the log in the format of Data: {data}```

### Let's save our work, and, try to run the program with VS Code. See the snip below, the final code is available "here"

- Use CoPilot to assist!
- If extensions are missing use the CoPilot Chat dialog to help resolve any missing extensions, or references
- Install extensions, or add missing **using** statements, stop and restart VS Code
  
![Step5a SampleCodeSnip](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/0cbff455-c064-4f80-9c8b-8f431f583619)

## Section 6: Final Thoughts

GitHub Copilot revolutionizes the way we write code, making development more efficient and enjoyable. Experiment with Copilot in various scenarios, explore its capabilities, and enhance your coding productivity.

Feel free to share your experiences, report issues, or contribute to the GitHub Copilot community.

Happy coding!
