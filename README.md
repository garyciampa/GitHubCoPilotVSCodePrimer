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

### Using the GitHub Copilot "Chat" prompt dialog, here are a few suggestions for a starting point: 

4. What azure service is recommended to create a REST endpoint for connecting to Cosmos Db
5. What vs code extentions are required to create an azure function and run with local storage for testing
6. Wat .net packages are required to run a function in azure, access keyvault and connect to cosmos db
7. What .net using statements are required for an http post, access keyvault and connect to cosmos db
8. How do I create an azure http request .net function in visual studio code
9. What dotnet commands are required to create an azure http function

![GitHub Copilot Chat sample prompt dialog](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/74eef4e8-e718-44de-b6e3-613194e7d362)

## Section 4: Creating an Azure Function with GitHub CoPilot and VS Code

Learn how to create an Azure Function using GitHub Copilot and Visual Studio Code with the following steps:

1. Install the required Azure extensions in VS Code. **Ask CoPilot how**
2. Open a new file or project for your Azure Function.
3. Optionally: use VS Code **terminal** & creating the function with **dotnet func** commands; Or, using the VS Code Azure Function **create** dialog: 
   
```bash
#
# Sample func init command in VS Code Terminal to create
# a new Azure function in CWD, using Azure Function Core V4 
$PS1> func init MyHttpFunction --dotnet  --AzureFunctionsVersion v4
$PS1 cd MyHttpFunction 
$PS1> func new --name MyHttpTrigger --template "HTTP trigger" --authlevel "anonymous"
```

4.  Optionally, use the VS Code *builtin* Azure Function create feature

![VS Code Azure Function create dialog](https://github.com/garyciampa/GitHubCoPilotVSCodePrimer/assets/56933939/7e2a02c4-c1fe-408c-a43f-464c83bea73c)
 
5. Utilize Copilot to speed up your function's code implementation.

## Section 5: GitHub Copilot Prompts for VS Code to connect to Azure Key Vault and Azure Cosmos DB

Copilot seamlessly integrates with Azure services. Follow these prompts in VS Code to connect to Azure Key Vault and Azure Cosmos DB:

1. Open the desired file or project.
2. Use Copilot to generate code snippets for connecting to Azure Key Vault and Cosmos DB.
3. Customize the generated code based on your specific configurations.

## Section 6: Final Thoughts

GitHub Copilot revolutionizes the way we write code, making development more efficient and enjoyable. Experiment with Copilot in various scenarios, explore its capabilities, and enhance your coding productivity.

Feel free to share your experiences, report issues, or contribute to the GitHub Copilot community.

Happy coding!
