using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestAdega.TestsData
{
    public class RespostasControllerModelsTheoryAtivos
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Respostas
                     {
                      IdUsuario = 1,
                      IdResposta = 1,
                      Resposta = "TESTE RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
                    }
                };
            }
        }

    }
    public class RespostasControllerModelsTheoryAtualizar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Respostas
                     {
                      IdUsuario = 1,
                      IdResposta = 1,
                      Resposta = "TESTE TESTE RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
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
                    new Respostas
                     {
                      IdUsuario = 1000,
                      IdResposta = 1,
                      Resposta = "TESTE TESTE RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
                    }
                };
            }
        }
    }
    public class RespostasControllerModelsTheorySalvar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Respostas
                     {
                      IdUsuario = 1,
                      IdResposta = 2,
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
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
                     new Respostas
                     {
                      IdUsuario = Convert.ToInt32(null),
                      IdResposta = Convert.ToInt32(null),
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
                    },  new Respostas
                     {
                      IdUsuario = Convert.ToInt32(null),
                      IdResposta = Convert.ToInt32(null),
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime(null),
                      IdQuestionario = Convert.ToInt32(null)
                    }
                };
            }
        }
    }
    public class RespostasControllerModelsTheoryExcluir
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                     new Respostas
                     {
                      IdUsuario = 1,
                      IdResposta = 2,
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 1
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
                    new Respostas
                     {
                      IdUsuario = 200,
                      IdResposta = 100,
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 10
                    }, new Respostas
                     {
                      IdUsuario = 222,
                      IdResposta = 111,
                      Resposta = "RESPOSTAS",
                      DataHora = Convert.ToDateTime("2020-01-01T00:00:00"),
                      IdQuestionario = 111
                    }
                };
            }
        }
    }
}
