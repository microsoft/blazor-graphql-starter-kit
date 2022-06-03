using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace blazorui
{
    public class GraphQLAPIClient
    {
        private readonly HttpClient _httpClient;

        public GraphQLAPIClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetHelloworld()
        {
            GraphQLRequest request = new(_httpClient)
            {
                OperationName = "welcome",
                Query = @"{
                            welcome{}
                        }"
            };

            string response = (await request.PostAsync()).RootElement.GetProperty("welcome").GetString();

            return response;
        }
       
    }
}