using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Servico
{
    public class DetalhesCervejaServico
    {

        private readonly DetalhesCervejaRepositorio _detalhesCervejaRepositorio;

        public DetalhesCervejaServico()
        {
            _detalhesCervejaRepositorio = new DetalhesCervejaRepositorio();
        }

        public NotificationResult Salvar(DetalhesCervejas entidade)
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

                    _detalhesCervejaRepositorio.Adicionar(entidade);


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


        public NotificationResult Atualizar(DetalhesCervejas entidade)
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

                    _detalhesCervejaRepositorio.Atualizar(entidade);

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


        public string Excluir(DetalhesCervejas entidade)
        {
            _detalhesCervejaRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<DetalhesCervejas> ListarTodos()
        {
            return _detalhesCervejaRepositorio.ListarTodos();
        }

        public IEnumerable<DetalhesCervejas> ListarAtivos()
        {
            return _detalhesCervejaRepositorio.ListarAtivos();
        }

    }
}
