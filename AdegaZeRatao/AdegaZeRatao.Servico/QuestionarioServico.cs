using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dados;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Servico
{
    public class QuestionarioServico
    {

        private readonly QuestionarioRepositorio _questionarioRepositorio;

        public QuestionarioServico()
        {
            _questionarioRepositorio = new QuestionarioRepositorio();
        }

        public NotificationResult Salvar(Questionario entidade)
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

                    _questionarioRepositorio.Adicionar(entidade);


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


        public NotificationResult Atualizar(Questionario entidade)
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

                    _questionarioRepositorio.Atualizar(entidade);

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


        public string Excluir(Questionario entidade)
        {
            _questionarioRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Questionario> ListarTodos()
        {
            return _questionarioRepositorio.ListarTodos();
        }

        public IEnumerable<Questionario> ListarAtivos()
        {
            return _questionarioRepositorio.ListarAtivos();
        }


    }
}
