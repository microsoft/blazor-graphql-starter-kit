using HotChocolate.AspNetCore.Authorization;

namespace graphqlapi.Resolvers
{
    [Authorize]
    public class Query
    {
        public string Welcome()
        {
            return "Congrats on making your first query!";
        }
    }
}
