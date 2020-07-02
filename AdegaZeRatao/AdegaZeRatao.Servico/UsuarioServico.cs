using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace AdegaZeRatao.Servico
{
    public class UsuarioServico
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public dynamic Salvar(Usuario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                IEnumerable<Usuario> user = _usuarioRepositorio.ListarEmail(entidade.Email);

                if (user.Count() > 0)
                {

                    var ret = new
                    {
                        Retorno = "Email , já cadastrado, Tente Outro.",
                        status = 204


                    };
                    return ret;
                }
                else
                {

                    string senhacpt = entidade.Senha;
                    // string strToken = JsonConvert.SerializeObject(credenciais);
                    byte[] ObjectByte = System.Text.Encoding.ASCII.GetBytes(senhacpt);
                    string novaSenha = Convert.ToBase64String(ObjectByte);

                    IEnumerable<Usuario> usr = _usuarioRepositorio.ListarTodos();
                    int usuario = usr.Select(u => u.IdUsuario).LastOrDefault();
                    usuario++;
                    entidade.IdUsuario = usuario;
                    entidade.Senha = novaSenha;
                     _usuarioRepositorio.Adicionar(entidade);


                    var rt = new
                    {
                        Retorno = "Usuario Cadastrado!",
                        status = 200


                    };
                    return rt;
                }
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }


        public NotificationResult Atualizar(Usuario entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                //entidade.DataCadastro = DateTime.Now;

                //if (entidade.Estoque < 0)
                //    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                //if (entidade.PrecoCusto <= 0)
                //    notificationResult.Add(new NotificationError("Preço de Custo inválido."));

                if (notificationResult.IsValid)
                {

                    _usuarioRepositorio.Atualizar(entidade);

                    notificationResult.Add("Produto cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }


        public string Excluir(Usuario entidade)
        {
            _usuarioRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Usuario> ListarTodos()
        {
            return _usuarioRepositorio.ListarTodos();
        }

        public IEnumerable<Usuario> ListarAtivos()
        {
            return _usuarioRepositorio.ListarAtivos();
        }


        public dynamic Validar(Usuario entidade)
        {
            if (entidade.Email == "" || entidade.Senha == "")
            {
                return "Preencha os dados Novamente!";
            }

            else
            {
                IEnumerable<Usuario> user = _usuarioRepositorio.ListarEmail(entidade.Email);
                string senhacpt = user.Select(u => u.Senha).FirstOrDefault();


                // string strToken = JsonConvert.SerializeObject(credenciais);
                byte[] ObjectByte = System.Text.Encoding.ASCII.GetBytes(entidade.Senha);
                string novaSenha = Convert.ToBase64String(ObjectByte);

                
                if (user.Count() > 0)
                {
                    if (novaSenha.Equals(senhacpt))
                    {
                        var ret = new
                        {
                            Retorno = "TESTE",
                            status = 200


                        };
                        return ret;
                    }
                    else
                    {
                        var ret2 = new
                        {
                            Retorno = "Senhas Não Conferem.",
                            status = 204
                        };
                        return ret2;
                    }
                    
                }
                else
                {
                    var rt = new
                    {
                        Retorno = "TENTE NOVAMENTE",
                        status = 204


                    };
                    return rt;
                }

            }

        }


    }
}
