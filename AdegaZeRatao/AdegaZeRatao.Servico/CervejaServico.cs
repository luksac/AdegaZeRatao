using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using System;
using AdegaZeRatao.Servico;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using System.Collections.Generic;

namespace AdegaZeRatao.Servico
{
    public class CervejaServico
    {
        private readonly CervejaRepositorio _cervejaRepositorio;

        public CervejaServico()
        {
            _cervejaRepositorio = new CervejaRepositorio();
        }

        public NotificationResult Salvar(Cerveja entidade)
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

                        _cervejaRepositorio.Adicionar(entidade);
                 

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


        public NotificationResult Atualizar(Cerveja entidade)
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

                        _cervejaRepositorio.Atualizar(entidade);

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


        public string Excluir(Cerveja entidade)
        {
            return "";
        }

        public IEnumerable<Cerveja> ListarTodos()
        {
            return _cervejaRepositorio.ListarTodos();
        }

        public IEnumerable<Cerveja> ListarAtivos()
        {
            return _cervejaRepositorio.ListarAtivos();
        }

    }
}
