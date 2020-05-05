using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Mvc;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;

namespace AdegaZeRataoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionarioController : ControllerBase
    {
        private readonly QuestionarioServico questionarioServico;

        public QuestionarioController()
        {
            questionarioServico = new QuestionarioServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Questionario> Ativos() => questionarioServico.ListarAtivos();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cerveja> ListarTodosComEstoqueZerado()
        //{
        //    return cervejaServico.ListarTodosComEstoqueZerado();
        //}
        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Questionario entidade)
        {
            return questionarioServico.Atualizar(entidade);
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Questionario entidade)
        {
            return questionarioServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Questionario entidade)
        {
            return questionarioServico.Excluir(entidade);
        }


    }
}