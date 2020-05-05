using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;
using AdegaZeRatao.Servico;

namespace AdegaZeRataoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RespostasController : ControllerBase
    {

        private readonly RespostasServico respostasServico;

        public RespostasController()
        {
            respostasServico = new RespostasServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Respostas> Ativos() => respostasServico.ListarAtivos();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cerveja> ListarTodosComEstoqueZerado()
        //{
        //    return cervejaServico.ListarTodosComEstoqueZerado();
        //}
        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Respostas entidade)
        {
            return respostasServico.Atualizar(entidade);
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Respostas entidade)
        {
            return respostasServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Respostas entidade)
        {
            return respostasServico.Excluir(entidade);
        }


    }
}