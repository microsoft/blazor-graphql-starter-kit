using graphqlapi.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace graphqlapi.Resolvers
{
    public class Query
    {
        public string Welcome(ClaimsPrincipal claimsPrincipal)
        {
            return $"Congrats on making your first query!. You are authenticated as: {claimsPrincipal.Identity.Name}";
        }

        public IList<Questionnaire> GetQuestionnairs()
        {
            return new List<Questionnaire>()
            {
                new Questionnaire()
                {
                    Title="Sample 1",
                    Date=DateTime.Now,
                },
                new Questionnaire()
                {
                    Title="Sample 2",
                    Date=DateTime.Now,
                },
            };
        }
    }
}
