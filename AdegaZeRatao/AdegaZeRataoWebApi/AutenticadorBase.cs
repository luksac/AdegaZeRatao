using AdegaZeRataoWebApi.Classes;
using AdegaZeRataoWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AdegaZeRataoWebApi
{
    public class AutenticadorBase{}

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AutenticacaoBasicaAttribute : TypeFilterAttribute
    {
        public AutenticacaoBasicaAttribute() : base(typeof(AutenticacaoBasicaHandler))
        {
        }
    }

    public class AutenticacaoBasicaHandler : IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                string cabecalho = context.HttpContext.Request.Headers["Authorization"];

                if (cabecalho != null)
                {

                    var authHeaderValue = AuthenticationHeaderValue.Parse(cabecalho);
                    if (authHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        var credenciais = Encoding.UTF8
                                            .GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty))
                                            .Split(':', 3);

                        if (credenciais.Length == 3)
                        {
                            Credenciais credenAuth = new Credenciais();
                            credenAuth.UserName = credenciais[0];
                            credenAuth.Senha = credenciais[1];
                            credenAuth.Data = Convert.ToDateTime(credenciais[2]);

                            if (EstaAutenticado(context, credenAuth)){
                                return;
                            }
                        }

                    }
                }

                NaoAutorizadoResult(context);
            }
            catch (FormatException ex)
            {
                NaoAutorizadoResult(context);
            }
        }

        public bool EstaAutenticado(AuthorizationFilterContext context, Credenciais credenciais)
        {
            
            System.DateTime tempoExpiracao = new System.DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, (DateTime.Now.Minute - Convert.ToInt32(FuncoesUteis.Get("Expiracao"))), DateTime.Now.Second);
            return credenciais.UserName == FuncoesUteis.Get("Usuario") && credenciais.Senha == FuncoesUteis.Get("Senha") && credenciais.Data > tempoExpiracao;
        }

        private void NaoAutorizadoResult(AuthorizationFilterContext context)
        {
            // Return 401 and a basic authentication challenge (causes browser to show login dialog)
            context.Result = new UnauthorizedResult();
        }
    }

}
