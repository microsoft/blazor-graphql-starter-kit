# Project

> This repo contains sample code for creating a secure app with the following stack.
> UI: Blazor Web Assembly (WASM)
> API: GraphQL based on the HotChocolate package

> In this app the UI uses Azure AD for auth.  The API is protected and only accepts authorized requests with a valid Oaauth token.


## Steps to deploy in your Azure subscription

### Azure Storage Static Site
Follow these instructions to create a static site: https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website
Example name used in this starter kit: blazorgraphqlui

### Azure App Service (dotnet core, Windows)
Follow these instructions to create a dotnet Windows site: https://docs.microsoft.com/en-us/azure/app-service/quickstart-arm-template?pivots=platform-linux
Example name used in this starter kit: blazorgraphqlapi

### Azure AD
API App Registration
**Create an App Registration for the API**
Name: blazor-graphql-api
Accounts in this organization
Redirect URL: https://localhost:5001/.auth/login/aad/callback https://blazorgraphqlapi.azurewebsites.net/.auth/login/aad/callback

Add a Client Secret:
In the Portal click "Certificates and Secrets" and add a new one.  Please copy it somewhere safe.

Expose an API 
In the portal click on Expose an API.
Add a new scope:
leave the api url the same (ex: api://18715d1e-141c-445e-999c-432aba6f12d2)

scope: graphql.all
Who can consent: Admins and users
Admin Consent Title: AdminGraphConsent
Admin Consent Description: Allows users to read graphql data
User Consent Title: UserGraphConsent
User Consent Description: 
Status: Enabled
Click Save and ok.



**Things you will need for further setup (copy somewhere)
Client ID
Client Secret
API Url (ex: api://18715d1e-141c-445e-999c-432aba6f12d2))
Tenant ID


#### UI App Registration

**Create an App Registration for the UI**

Name: blazor-graphql-ui
Accounts in this organization
Redirect URLs: (Single Page App): https://localhost:5001/authentication/callback https://blazorgraphqlui.azurewebsites.net/authentication/callback

**Configure the App Registration**
In the portal click on Authentication
Check both ID Token and Access Token boxes

**Add API Permissions**
In the portal click on API Permissions
Click + Add a New Permission
Click on "My APIs"
Click on the API you exposed earlier (for example: blazor-graphql-api)
Check the checkbox for 'graphql.all'
Click 'Add Permission'



**Things you will need for further setup (copy somewhere)
Client ID
Tenant ID

Now go back to the App Registration you created for the API.
Click on Expose an API
And add the UI app's client ID to the list of authorized Apps.'

### Blazor App
From Nothing:
* Create new VS Solution with a Blazor App with Microsoft Identity Provider Auth.
----
* Open the solution file
* Edit the app-settings.json file with your client id and tenant
EX (Note below values are not valid and need to be replaced with valid values
```json
  "AzureAd": {
    "Authority": "https://login.microsoftonline.com/5df988bf-86f1-41af-91ab-2d7cd011db47",
    "ClientId": "2c92f0fd-70bf-468a-83d7-94f8a3074650",
    "ValidateAuthority": true
  }
}
```

* Run locally (Press F5)
If your app runs on https://localhost:44362 then you should be able to login.  If your app runs on another port or runs in http then please change the blazor-graphql app registration's reply_url.'

* Create an Azure Static Blob site
* Enable static website hosting: https://docs.microsoft.com/en-us/azure/storage/blobs/storage-blob-static-website-how-to?tabs=azure-portal#enable-static-website-hosting
* Configure the Azure Static Blob Site
* Deploy to a static blob site


* Use Azure Active Directory (AAD) for authentication: https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/standalone-with-azure-active-directory?view=aspnetcore-5.0

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
