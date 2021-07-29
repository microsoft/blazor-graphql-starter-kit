using HotChocolate.AspNetCore.Authorization;

namespace graphqlapi.Resolvers
{
    public class Query
    {
        public string Welcome()
        {
            return "Congrats on making your first query!";
        }
    }
}
