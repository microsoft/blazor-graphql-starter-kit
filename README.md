# Project

> This repo contains sample code for creating a secure app with the following stack.
> UI: Blazor Web Assembly (WASM)
> API: GraphQL based on the HotChocolate package

> In this app the UI uses Azure AD for auth.  The API is protected and only accepts authorized requests with a valid Oaauth token.


## Steps to deploy in your Azure subscription

### Azure AD
API App Registration
* Create an App Registration for the API.
* Add a Client Secret
* Expose an API 
* Add the UI App Registration as a valid client

UI App Registration
* Create an App Registration for the UI
* Add API Permissions for Microsoft Graph profile
* Add the API Exposed API you created above


### Blazor App
* Open the solution file
* Edit the app-settings.json file
* Run locally
* Create an Azure Static Blob site
* Configure the Azure Static Blob Site
* Deploy to a static blob site


## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
