using graphqlapi.Models;
using System;
using System.Collections.Generic;

namespace graphqlapi.Services
{
    public class FhirServiceInMemory : IFhirService
    {
        private IList<Questionnaire> _questionnaires;

        public FhirServiceInMemory()
        {
            _questionnaires = LoadQuestionnaires();
        }

        public IList<Questionnaire> GetQuestionnaires()
        {
            return _questionnaires;
        }

        private IList<Questionnaire> LoadQuestionnaires()
        {
            IList<Questionnaire> questionnaires = new List<Questionnaire>();

            Questionnaire generalQuestionnaire = new Questionnaire()
            {
                Text = new Narrative() { 
                    Status = NarrativeStatus.Generated, 
                    Div = "<div xmlns=\"http://www.w3.org/1999/xhtml\">\n      <pre>\n            1.Comorbidity?\n              1.1 Cardial Comorbidity\n                1.1.1 Angina?\n                1.1.2 MI?\n              1.2 Vascular Comorbidity?\n              ...\n            Histopathology\n              Abdominal\n                pT category?\n              ...\n          </pre>\n    </div>"
                }, 
                Url = new Uri("https://hl7.org/fhir/Questionnaire/3141"), 
                Title = "Cancer Quality Forum Questionnaire 2012", 
                Status = PublicationStatus.Draft, 
                Date = new DateTime(2012, 1, 1), 
                Items = new List<QuestionnaireItem>()
                {
                    new QuestionnaireItem()
                    {
                        LinkId = "1", 
                        Code = new List<Coding>()
                        {
                            new Coding()
                            {
                                System = new Uri("http://example.org/system/code/sections"), 
                                Code = "COMORBIDITY"
                            }
                        }, 
                        Type = QuestionnaireItemType.Group, 
                        Items = new List<QuestionnaireItem>()
                        {
                            new QuestionnaireItem()
                            {
                                LinkId = "1.1", 
                                Code = new List<Coding>()
                                {
                                    new Coding()
                                    {
                                        System = new Uri("http://example.org/system/code/questions"), 
                                        Code = "COMORB"
                                    }
                                }, 
                                Prefix = "1", 
                                Type = QuestionnaireItemType.Choice, 
                                Items = new List<QuestionnaireItem>()
                                {
                                    new QuestionnaireItem()
                                    {
                                        LinkId = "1.1.1", 
                                        Code = new List<Coding>()
                                        {
                                            new Coding()
                                            {
                                                System = new Uri("http://example.org/system/code/sections"), 
                                                Code = "CARDIAL"
                                            }
                                        }, 
                                        Type = QuestionnaireItemType.Group, 
                                        Items = new List<QuestionnaireItem>()
                                        {
                                            new QuestionnaireItem()
                                            {
                                                LinkId = "1.1.1.1", 
                                                Code = new List<Coding>()
                                                {
                                                    new Coding()
                                                    {
                                                        System = new Uri("http://example.org/system/code/questions"), 
                                                        Code = "COMORBCAR"
                                                    }
                                                }, 
                                                Prefix = "1.1", 
                                                Type = QuestionnaireItemType.Choice, 
                                                Items = new List<QuestionnaireItem>()
                                                {
                                                    new QuestionnaireItem()
                                                    {
                                                        LinkId = "1.1.1.1.1", 
                                                        Code = new List<Coding>()
                                                        {
                                                            new Coding()
                                                            {
                                                                System = new Uri("http://example.org/system/code/questions"), 
                                                                Code = "COMCAR00", 
                                                                Display = "Angina Pectoris"
                                                            }, 
                                                            new Coding()
                                                            {
                                                                System = new Uri("http://snomed.info/sct"), 
                                                                Code = "194828000", 
                                                                Display = "Angina (disorder)"
                                                            }
                                                        }, 
                                                        Prefix = "1.1.1", 
                                                        Type = QuestionnaireItemType.Choice
                                                    }, 
                                                    new QuestionnaireItem()
                                                    {
                                                        LinkId = "1.1.1.1.2", 
                                                        Code = new List<Coding>()
                                                        {
                                                            new Coding()
                                                            {
                                                                System = new Uri("http://snomed.info/sct"), 
                                                                Code = "22298006", 
                                                                Display = "Myocardial infraction (disorder)"
                                                            }
                                                        }, 
                                                        Prefix = "1.1.2", 
                                                        Type = QuestionnaireItemType.Choice
                                                    }
                                                }
                                            }, 
                                            new QuestionnaireItem()
                                            {
                                                LinkId = "1.1.1.2", 
                                                Code = new List<Coding>()
                                                {
                                                    new Coding()
                                                    {
                                                        System = new Uri("http://example.org/system/code/questions"), 
                                                        Code = "COMORBVAS"
                                                    }
                                                }, 
                                                Prefix = "1.2", 
                                                Type = QuestionnaireItemType.Choice
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }, 
                    new QuestionnaireItem()
                    {
                        LinkId = "2", 
                        Code = new List<Coding>()
                        {
                            new Coding()
                            {
                                System = new Uri("http://example.org/system/code/sections"), 
                                Code = "HISTOPATHOLOGY"
                            }
                        }, 
                        Type = QuestionnaireItemType.Group, 
                        Items = new List<QuestionnaireItem>()
                        {
                            new QuestionnaireItem()
                            {
                                LinkId = "2.1", 
                                Code = new List<Coding>()
                                {
                                    new Coding()
                                    {
                                        System = new Uri("http://example.org/system/code/sections"), 
                                        Code = "ABDOMINAL"
                                    }
                                }, 
                                Type = QuestionnaireItemType.Group, 
                                Items = new List<QuestionnaireItem>()
                                {
                                    new QuestionnaireItem()
                                    {
                                        LinkId = "2.1.2", 
                                        Code = new List<Coding>()
                                        {
                                            new Coding()
                                            {
                                                System = new Uri("http://example.org/system/code/questions"), 
                                                Code = "STADPT", 
                                                Display = "pT category"
                                            }
                                        }, 
                                        Type = QuestionnaireItemType.Choice
                                    }
                                }
                            }
                        }
                    }
                }
            };

            questionnaires.Add(generalQuestionnaire);

            return questionnaires;
        }
    }
}
