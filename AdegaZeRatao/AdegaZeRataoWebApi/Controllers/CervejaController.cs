using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;

namespace AdegaZeRataoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CervejaController : ControllerBase
    {
        private readonly CervejaServico cervejaServico;

        public CervejaController()
        {
            cervejaServico = new CervejaServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Cerveja> Ativos() => cervejaServico.ListarAtivos();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cerveja> ListarTodosComEstoqueZerado()
        //{
        //    return cervejaServico.ListarTodosComEstoqueZerado();
        //}

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Cerveja entidade)
        {
            return cervejaServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Cerveja entidade)
        {
            return cervejaServico.Excluir(entidade);
        }

    }
}
