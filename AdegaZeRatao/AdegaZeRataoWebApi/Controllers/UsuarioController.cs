﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRatao.Comum.NotificationPattern;
using AdegaZeRatao.Dominio;
using AdegaZeRatao.Servico;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AdegaZeRataoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AutenticacaoBasica]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioServico usuarioServico;

        public UsuarioController()
        {
            usuarioServico = new UsuarioServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Usuario> Ativos() => usuarioServico.ListarAtivos();

        [HttpPut("Atualizar")]
        public NotificationResult Atualizar(Usuario entidade)
        {
            return usuarioServico.Atualizar(entidade);
        }

        [EnableCors("Dominio")]
        [HttpPost("Salvar")]
        public dynamic Salvar(Usuario entidade)
        {
            return usuarioServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Usuario entidade)
        {
            return usuarioServico.Excluir(entidade);
        }

        [EnableCors("Dominio")]
        [HttpPost("Valida")]
        public dynamic Valida(Usuario entidade)
        {
            return usuarioServico.Validar(entidade);
        }

    }
}