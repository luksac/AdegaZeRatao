using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Mvc;

namespace AdegaZeRataoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeatlhesCervejaController : ControllerBase
    {
        private readonly DetalhesCervejaServico datelhesCervejasServico;

        public DeatlhesCervejaController()
        {
            datelhesCervejasServico = new DetalhesCervejaServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<DetalhesCervejas> Ativos() => datelhesCervejasServico.ListarAtivos();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cerveja> ListarTodosComEstoqueZerado()
        //{
        //    return cervejaServico.ListarTodosComEstoqueZerado();
        //}
        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(DetalhesCervejas entidade)
        {
            return datelhesCervejasServico.Atualizar(entidade);
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(DetalhesCervejas entidade)
        {
            return datelhesCervejasServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(DetalhesCervejas entidade)
        {
            return datelhesCervejasServico.Excluir(entidade);
        }


    }
}
