using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestAdega.TestsData
{
    public class  DetalhesCervejasControllerModelsTheoryAtivos
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new DetalhesCervejas
                    {
                       
                        IdDetalhe = 1,
                        Ranking = 1,
                        ProdutoQuantidade = 20,
                        PrecoSugerido = 4
                    }
                };
            }
        }
    }
    public class  DetalhesCervejasControllerModelsTheoryAtualizar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new DetalhesCervejas
                    {
                        IdDetalhe = 1,
                        Ranking = 1,
                        ProdutoQuantidade = 20,
                        PrecoSugerido = 10

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
                    new DetalhesCervejas
                    {
                        IdDetalhe = 1000,
                        Ranking = 1,
                        ProdutoQuantidade = 20,
                        PrecoSugerido = 10

                    }
                };
            }
        }
    }
    public class  DetalhesCervejasControllerModelsTheorySalvar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new DetalhesCervejas
                    {                       
                        IdDetalhe = 2,
                        Ranking = 2,
                        ProdutoQuantidade = 25,
                        PrecoSugerido = 12

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
                    new DetalhesCervejas
                    {
                        
                        IdDetalhe = Convert.ToInt32(null),
                        Ranking = 2,
                        ProdutoQuantidade = 25,
                        PrecoSugerido = 12

                    },new DetalhesCervejas
                    {
                        IdDetalhe = 3,
                        Ranking = Convert.ToInt32(null),
                        ProdutoQuantidade = Convert.ToInt32(null),
                        PrecoSugerido = 12

                    }
                };
            }
        }
    }
    public class DetalhesCervejasControllerModelsTheoryExcluir
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new DetalhesCervejas
                    {
                        IdDetalhe = 2,
                        Ranking = 2,
                        ProdutoQuantidade = 25,
                        PrecoSugerido = 12

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
                    new DetalhesCervejas
                    {
                        IdDetalhe = 222,
                        Ranking = 2,
                        ProdutoQuantidade = 25,
                        PrecoSugerido = 12

                    },new DetalhesCervejas
                    {
                        IdDetalhe = 333,
                        Ranking = 2,
                        ProdutoQuantidade = 25,
                        PrecoSugerido = 12

                    }
                };
            }
        }
    }

}
