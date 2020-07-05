using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestAdega.TestsData
{
    public class CervejaControllerModelsTheoryAtivos
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Cerveja
                    {
                        IdCerveja = Convert.ToInt32(null),
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

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
                    new Cerveja
                    {
                        IdCerveja = Convert.ToInt32(null),
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

                    }
                };
            }
        }

        public static IEnumerable<object[]> GetTestsModelsTheoryBadRequest
        {
            get
            {
                yield return new object[]
                {
                    new Cerveja
                    {
                        IdCerveja = Convert.ToInt32(null),
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

                    }
                };
            }
        }

    }
    public class CervejaControllerModelsTheoryAtualizar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Cerveja
                    {
                        IdCerveja = 1,
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

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
                    new Cerveja
                    {
                        IdCerveja = 10000,
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

                    }
                };
            }
        }
    }
    public class CervejaControllerModelsTheorySalvar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Cerveja
                    {
                        IdCerveja = 8,
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Ruim d mais"

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
                    new Cerveja
                    {
                        IdCerveja = Convert.ToInt32(null),
                        Categoria = null,
                        Tipo = null,
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

                    },new Cerveja
                    {
                        IdCerveja = 100,
                        Categoria = null,
                        Tipo = "Não Maltada",
                        IdDetalhes = Convert.ToInt32(null),
                        Descricao =  null

                    }
                };
            }
        }
    }
    public class CervejaControllerModelsTheoryExcluir
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Cerveja
                    {
                        IdCerveja = 8,
                        Categoria = "Popular",
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Ruim d mais"

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
                    new Cerveja
                    {
                        IdCerveja = 111,
                        Categoria = null,
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  "Só Deus"

                    },new Cerveja
                    {
                        IdCerveja = 222,
                        Categoria = null,
                        Tipo = "Não Maltada",
                        IdDetalhes = 1,
                        Descricao =  null

                    }
                };
            }
        }
    }

}
