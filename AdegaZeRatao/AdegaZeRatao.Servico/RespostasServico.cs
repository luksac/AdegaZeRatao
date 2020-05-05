using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Servico
{
    public class RespostasServico
    {

        private readonly RespostasRepositorio _respostasRepositorio;

        public RespostasServico()
        {
            _respostasRepositorio = new RespostasRepositorio();
        }

        public NotificationResult Salvar(Respostas entidade)
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

                    _respostasRepositorio.Adicionar(entidade);


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


        public NotificationResult Atualizar(Respostas entidade)
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

                    _respostasRepositorio.Atualizar(entidade);

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


        public string Excluir(Respostas entidade)
        {
            _respostasRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Respostas> ListarTodos()
        {
            return _respostasRepositorio.ListarTodos();
        }

        public IEnumerable<Respostas> ListarAtivos()
        {
            return _respostasRepositorio.ListarAtivos();
        }

    }
}
