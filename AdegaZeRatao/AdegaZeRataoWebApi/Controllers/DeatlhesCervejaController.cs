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
    public class DeatlhesCervejaController : ControllerBase
    {
        private readonly DetalhesCervejaServico datelhesCervejasServico;

        public DeatlhesCervejaController()
        {
            datelhesCervejasServico = new DetalhesCervejaServico();
        }


        [EnableCors("Dominio")]
        [HttpGet("ativos")]
        public IEnumerable<DetalhesCervejas> Ativos() => datelhesCervejasServico.ListarAtivos();
        
        [EnableCors("Dominio")]
        [HttpGet("SelecionaPorId/{IdDetalhe:int}")]
        public DetalhesCervejas SelecionaPorId(int IdDetalhe) => datelhesCervejasServico.SelecionaPorId(IdDetalhe);
      

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
