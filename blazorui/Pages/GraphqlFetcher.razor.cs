using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorui.Pages
{
    [Authorize]
    public partial class GraphqlFetcher
    {
        [Inject]
        private GraphQLAPIClient graphqlclient { get; set; } 
        private string graphqlresponse { get; set; }
        private bool graphqlcallfinished { get; set; }

        protected override async Task OnInitializedAsync()
        {
            graphqlresponse = null;
            graphqlcallfinished = false;
            graphqlresponse = await graphqlclient.GetHelloworld();
            graphqlcallfinished = true;

        }

    }
}
