using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestAdega.TestsData
{
    public class UsuarioControllerModelsTheoryAtivos
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Usuario
                    {

                        IdUsuario = 1,
                        Email = "pvaalmeida.p@gmail.com",
                        Senha = "TesteTeste"

                    }
                };
            }
        }

    }
    public class UsuarioControllerModelsTheoryAtualizar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                     new Usuario
                    {

                        IdUsuario = 1,
                        Email = "pvaalmeida.p@gmail.com",
                        Senha = "ZeRatao"

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
                    new Usuario
                    {
                        IdUsuario = 1000,
                        Email = "pvaalmeida.p@gmail.com",
                        Senha = "ZeRatao"

                    }
                };
            }
        }
    }
    public class UsuarioControllerModelsTheorySalvar
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Usuario
                    {

                        IdUsuario = 2,
                        Email = "pvaalmeida.a@outlook.com",
                        Senha = "ZeRatao123"

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
                   new Usuario
                    {
                        IdUsuario = Convert.ToInt32(null),
                        Email = "pvaalmeida.a@outlook.com",
                        Senha = null
                    }
                };
            }
        }
    }
    public class UsuarioControllerModelsTheoryExcluir
    {
        public static IEnumerable<object[]> GetTestsModelsTheorySuccess
        {
            get
            {
                yield return new object[]
                {
                    new Usuario
                    {

                        IdUsuario = 2,
                        Email = "pvaalmeida.a@outlook.com",
                        Senha = "ZeRatao123"

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
                    new Usuario
                    {

                        IdUsuario = 222,
                        Email = "pvaalmeida.a@outlook.com",
                        Senha = "ZeRatao123"

                    }, new Usuario
                    {

                        IdUsuario = 2000,
                        Email = "pvaalmeida.a@outlook.com",
                        Senha = "ZeRatao123"

                    }
                };
            }
        }
    }
}
