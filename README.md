# AzFunctionUnzip

A simple Azure Function to Unzip files from a blob storage container to another one

The following features are supported in this current version:
1. Supported Archive Types: .zip, .rar
     
2. Password protetected zip files

     *The current solution provisions an Azure KeyVault instance for storing the zip archive(s) password used during the unzipping process.  If password protected zip files are uploaded to the blob storage container, this would be the password used when attempting to un-zip the files into the destination storage container.**

## How to deploy

To deploy all the resources in your Azure subscription, just click on the **Deploy to Azure** button

<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FHamzaBoukraa%2FAzFunctionUnzip%2Fmain%2Fdeployment%2FdeployAzure.json" target="_blank"><img src="https://aka.ms/deploytoazurebutton" alt="Deploy to Azure"/></a>


Fill-up the form and voila! It will be automatically deployed in your Azure subscription. If you don't own an Azure subscription already, you can create your **free** account today. It comes with 200$ credit, so you can experience almost everything without spending a dime. 
[Create your free Azure account today](https://azure.microsoft.com/free)

Learn more on [how to deploy you Azure Function automatically or using the Azure Resource Manager (ARM) template](https://docs.microsoft.com/azure/azure-functions/functions-infrastructure-as-code)

![CreationForm][CreationForm]

## How to use it.

You can upload files to an Azure Blob storage using many different tools and code, but for this quick introduction let's use the Azure Portal.

Once [deployed](https://github.com/HamzaBoukraa/AzFunctionUnzip#how-to-deploy), open the Azure portal [portal.azure.com](https://portal.azure.com/)

1. navigate to the resource Group you just deployed (ex: demoAzFunctionUnzip).

    ![resourceGroup][resourceGroup]

1. Select the **Storage Account** whose name starts with "dropzone".
1. Click on **Blobs**, in the middle of the screen.
1. Click on the **input-files** container. 
1. Click on the Upload button, and you can now upload a zip file.

    ![uploadFile][uploadFile]

1. After a few second the files you uploaded will be Unzipped into the blob storage container **output-files**.


## Run Locally & DevContainer

You can run the Azure Function locally or in a dev Container (files provided in folder .devcontainer). 
You will need:
- a `local.settings.json` file at the root. You can renamed and update local.settings.example.json or use it as template.
- a storage account in Azure or using the emulator
- a KeyVault with a secret `ZipPassword`.


## Continuous Integration (CI)

As you can see by the status badge [![Build Status](https://dev.azure.com/HamzaBoukraa/AzFunctionUnzip/_apis/build/status/HamzaBoukraa.AzFunctionUnzip?branchName=main)](https://dev.azure.com/HamzaBoukraa/AzFunctionUnzip/_build/latest?definitionId=23&branchName=main) at the top of the page this project is automatically build at every push. 

Have a look, the [Azure DevOps](https://dev.azure.com/HamzaBoukraa/AzFunctionUnzip/) project is **public**! 


### Create a Continuous Integration, Continuous Deployment (CI-CD) for your Azure Function

In this video, I show you how to write an Azure Resource Manager (#ARM) template to deploy automatically your serverless Azure Function to Azure. It can be then used with a "Deploy to Azure" button from GitHub or any website, or in an Azure Pipeline to complete a Continuous Integration, Continuous Deployment (CI-CD) solution.

[![FunctionCICD][FunctionCICD]](https://www.youtube.com/watch?v=GRztpy337kU)


There is also a **written version** if you prefer reading: http://www.frankysnotes.com/2019/07/four-ways-to-deploy-your-azure-function.html


## More details

I have a [blog post](https://www.frankysnotes.com/2019/02/how-to-unzip-automatically-your-files.html) about this Azure Function. 

I also have a video where I build and test the function.

[![Auto-UnzipFunction_YT][Auto-UnzipFunction_YT]](https://www.youtube.com/watch?v=GRztpy337kU)
  

I also have an extended version where I introduce more the Visual Studio Extension to work with Azure Function. And explain more details about the Azure Function V2.

[![AzureFunctionWithVSCode_YT][AzureFunctionWithVSCode_YT]](https://www.youtube.com/watch?v=t9PvXWEzU-o)


## Contributing ✨

Want to contribute? Check out our [Code of Conduct](CODE_OF_CONDUCT.md) and [Contributing](CONTRIBUTING.md) docs. This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification.  Contributions of any kind welcome!

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):


[CreationForm]: /medias/CreationForm.png "Creation Form"
[resourceGroup]: /medias/resourceGroup.png "Select the ResourceGroup"
[uploadFile]: /medias/uploadFile.png "Upload Zip file"
[FunctionCICD]: /medias/AzureFunctionCICD_YT.png "YouTube thumbnail"
[Auto-UnzipFunction_YT]: /medias/Auto-UnzipFunction_YT.png "YouTube thumbnail"
[AzureFunctionWithVSCode_YT]: /medias/AzureFunctionWithVSCode_YT.png "YouTube thumbnail"


<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="http://HamzaBoukraa.com"><img src="https://avatars3.githubusercontent.com/u/2404846?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Hamza Boukraa</b></sub></a><br /><a href="https://github.com/HamzaBoukraa/AzFunctionUnzip/commits?author=HamzaBoukraa" title="Code">💻</a> <a href="#video-HamzaBoukraa" title="Videos">📹</a> <a href="https://github.com/HamzaBoukraa/AzFunctionUnzip/commits?author=HamzaBoukraa" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/mreyeros"><img src="https://avatars3.githubusercontent.com/u/964690?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Michael Reyeros</b></sub></a><br /><a href="https://github.com/HamzaBoukraa/AzFunctionUnzip/commits?author=mreyeros" title="Code">💻</a> <a href="#maintenance-mreyeros" title="Maintenance">🚧</a> <a href="https://github.com/HamzaBoukraa/AzFunctionUnzip/pulls?q=is%3Apr+reviewed-by%3Amreyeros" title="Reviewed Pull Requests">👀</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->
