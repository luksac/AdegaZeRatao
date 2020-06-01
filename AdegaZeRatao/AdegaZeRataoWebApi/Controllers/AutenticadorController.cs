using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdegaZeRataoWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdegaZeRataoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AutenticadorController : ControllerBase
    {
        [HttpGet("Token")]
        public dynamic Token(Credenciais credenciais)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var errToken = new { Erro = "Favor verificar dados de objeto!" };

                    return errToken;
                }

                string strToken = credenciais.UserName + ":" + credenciais.Senha + ":" + credenciais.Data;
                // string strToken = JsonConvert.SerializeObject(credenciais);
                byte[] ObjectByte = System.Text.Encoding.ASCII.GetBytes(strToken);
                string Token = Convert.ToBase64String(ObjectByte);

                Token RetornoToken = new Token();
                RetornoToken.Tokenizer = Token;

                return RetornoToken;
            }
            catch (Exception ex)
            {
                return ex;
            }

        }
    }
}