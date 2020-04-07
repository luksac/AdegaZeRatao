using AdegaZeRatao.Dominios;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Negocio.AdegaZR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CervejaController : ControllerBase
    {
        #region Ping´s
        [HttpGet]
        [Route("Ping")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "HTTP GET", "ping!" };
        }
        [HttpPost]
        [Route("Ping")]
        public ActionResult<IEnumerable<string>> Post()
        {
            return new string[] { "HTTP POST", "ping!" };
        }
        [HttpPut]
        [Route("Ping")]
        public ActionResult<IEnumerable<string>> Put()
        {
            return new string[] { "HTTP PUT", "ping!" };
        }
        [HttpDelete]
        [Route("Ping")]
        public ActionResult<IEnumerable<string>> Delete()
        {
            return new string[] { "HTTP DELETE", "ping!" };
        }
        #endregion

        private readonly CervejaServico cervejaServico;

        public CervejaController()
        {
            cervejaServico = new CervejaServico();
        }

        [HttpGet("lstCerveja")]
        public IEnumerable<Cerveja> Listar() => cervejaServico.ListaCervejas();

        //[HttpPost("salvarCerveja")]
        //public NotificationResult SalvarCerveja(Cerveja entidade)
        //{
        //    return cervejaServico.Salvar(entidade);
        //}

        [HttpDelete("deleteCerveja")]
        public string DeleteCerveja(Cerveja entidade)
        {
            return cervejaServico.Excluir(entidade);
        }
    }
}