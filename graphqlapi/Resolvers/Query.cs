using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using HotChocolate;
using HotChocolate.Types;
using graphqlapi.Models;
using System;

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
