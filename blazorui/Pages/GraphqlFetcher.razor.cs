using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace blazorui.Pages
{
    [Authorize]
    public partial class GraphqlFetcher
    {
        [Inject]
        private GraphQLAPIClient graphqlclient { get; set; }
        [Inject]
        IAccessTokenProvider TokenProvider { get; set; }
        private string graphqlresponse { get; set; }
        private bool graphqlcallfinished { get; set; }
        private string Errors { get; set; }
        private string AccessToken { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
            AccessToken = "";
            Errors = "";
            graphqlresponse = "";
            var accessTokenResult = await TokenProvider.RequestAccessToken();
            if (accessTokenResult.TryGetToken(out var token))
            {
                AccessToken = token.Value;
            }

            
            graphqlcallfinished = false;
            try
            {
                graphqlresponse = await graphqlclient.GetHelloworld();
            }
            catch (ApplicationException e)
            {
                Errors = e.Message;
            }
            graphqlcallfinished = true;

        }

    }
}
