using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdegaZeRataoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[AutenticacaoBasica]
    public class AvaliacaoController : ControllerBase
    {

        private readonly AvaliacaoServico avaliacaoervico;

        public AvaliacaoController()
        {
            avaliacaoervico = new AvaliacaoServico();
        }


        [EnableCors("Dominio")]
        [HttpGet("ativos")]
        public IEnumerable<Avaliacao> Ativos() => avaliacaoervico.ListarAtivos();

        [EnableCors("Dominio")]
        [HttpGet("SelecionaPorId/{IdCerveja:int}")]
        public IEnumerable<Avaliacao> SelecionaPorId(int IdCerveja) => avaliacaoervico.SelecionaPorId(IdCerveja);


        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Avaliacao entidade)
        {
            return avaliacaoervico.Atualizar(entidade);
        }

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Avaliacao entidade)
        {
            return avaliacaoervico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Avaliacao entidade)
        {
            return avaliacaoervico.Excluir(entidade);
        }

    }
}