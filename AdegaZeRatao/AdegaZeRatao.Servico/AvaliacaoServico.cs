using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Servico
{
    public class AvaliacaoServico
    {

        private readonly AvaliacaoRepositorio _avaliacaoRepositorio;

        public AvaliacaoServico()
        {
            _avaliacaoRepositorio = new AvaliacaoRepositorio();
        }

        public NotificationResult Salvar(Avaliacao entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {

                if (notificationResult.IsValid)
                {

                    _avaliacaoRepositorio.Adicionar(entidade);


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


        public NotificationResult Atualizar(Avaliacao entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {

                if (notificationResult.IsValid)
                {

                    _avaliacaoRepositorio.Atualizar(entidade);

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


        public string Excluir(Avaliacao entidade)
        {
            _avaliacaoRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Avaliacao> ListarTodos()
        {
            return _avaliacaoRepositorio.ListarTodos();
        }

        public IEnumerable<Avaliacao> ListarAtivos()
        {
            return _avaliacaoRepositorio.ListarAtivos();
        }

        public IEnumerable<Avaliacao> SelecionaPorId(int IdCerveja)
        {
            return _avaliacaoRepositorio.Listar(IdCerveja);
        }

    }
}
