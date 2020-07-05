using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestAdega.TestsData
{
    public class QuestionarioControllerModelsTheoryAtivos
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Questionario
                    {
                        IdQuestionario =  0,
                        Pergunta = "então?",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }
    }
    public class QuestionarioControllerModelsTheoryAtualizar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                     new Questionario
                    {
                        IdQuestionario =  1,
                        Pergunta = "TESTE TESTE",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }

        public static IEnumerable<object[]> GetTestsModelsTheoryNoContent
        {
            get
            {
                yield return new object[]
                {
                    new Questionario
                    {
                        IdQuestionario =  Convert.ToInt32(null),
                        Pergunta = "TESTE TESTE",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }
    }
    public class QuestionarioControllerModelsTheorySalvar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                     new Questionario
                    {
                        IdQuestionario =  2,
                        Pergunta = "TESTE TESTE 22",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }

        public static IEnumerable<object[]> GetTestsModelsTheoryNoContent
        {
            get
            {
                yield return new object[]
                {
                     new Questionario
                    {
                        IdQuestionario =  Convert.ToInt32(null),
                        Pergunta = "EITA",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }
    }
    public class QuestionarioControllerModelsTheoryExcluir
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                     new Questionario
                    {
                        IdQuestionario =  2,
                        Pergunta = "TESTE TESTE 22",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }

        public static IEnumerable<object[]> GetTestsModelsTheoryNoContent
        {
            get
            {
                yield return new object[]
                {
                     new Questionario
                    {
                        IdQuestionario =  222,
                        Pergunta = "SERA",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }, new Questionario
                    {
                        IdQuestionario =  2121,
                        Pergunta = "ACHO Q NAO",
                        DataHora = Convert.ToDateTime("2020-05-19 22:26:11")

                    }
                };
            }
        }
    }
}
