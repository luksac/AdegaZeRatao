using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
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

        public NotificationResult Salvar(Usuario entidade)
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

                    _usuarioRepositorio.Adicionar(entidade);


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


    }
}
