using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace blazorui
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMsalAuthentication(options =>
            {
                builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
                options.ProviderOptions.LoginMode = "redirect";
                options.ProviderOptions.DefaultAccessTokenScopes.Add("openid");
                options.ProviderOptions.DefaultAccessTokenScopes.Add(builder.Configuration["APIScope"]);
                
            });
       
            builder.Services.AddHttpClient<GraphQLAPIClient>(
                    client => client.BaseAddress = new Uri("https://www.example.com/base"))
                    .AddHttpMessageHandler(sp => sp.GetRequiredService<BaseAddressAuthorizationMessageHandler>()
                        .ConfigureHandler(
                            authorizedUrls: new[] { builder.Configuration["APIBaseURL"] },
                            scopes: new[] { builder.Configuration["APIScope"] }));



            await builder.Build().RunAsync();
        }
    }
}
