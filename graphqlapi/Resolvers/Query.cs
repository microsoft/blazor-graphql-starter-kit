using System.Security.Claims;

namespace graphqlapi.Resolvers
{
    public class Query
    {
        public string Welcome(ClaimsPrincipal claimsPrincipal)
        {
            return $"Congrats on making your first query!. You are authenticated as: {claimsPrincipal.Identity.Name}";
        }
    }
}
