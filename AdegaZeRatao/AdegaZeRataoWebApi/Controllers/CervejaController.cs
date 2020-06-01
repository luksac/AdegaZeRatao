using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;

namespace AdegaZeRataoWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [AutenticacaoBasica]
    public class CervejaController : ControllerBase
    {
        private readonly CervejaServico cervejaServico;

        public CervejaController()
        {
            cervejaServico = new CervejaServico();
        }


        [EnableCors("Dominio")]
        [HttpGet("ativos")]
        
        public IEnumerable<Cerveja> Ativos() =>  cervejaServico.ListarAtivos();


        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Cerveja entidade)
        {
            return cervejaServico.Atualizar(entidade);
        }

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
