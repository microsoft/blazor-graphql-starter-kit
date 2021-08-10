using graphqlapi.Models;
using System.Collections.Generic;

namespace graphqlapi.Services
{
    public interface IFhirService
    {
        public IList<Questionnaire> GetQuestionnaires();
    }
}
