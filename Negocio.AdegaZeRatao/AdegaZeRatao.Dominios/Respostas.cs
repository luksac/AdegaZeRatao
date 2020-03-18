using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dominios
{
    public class Respostas
    {
        public int IdResposta { get; set; }
        public int IdQuestionario { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public string Resposta { get; set; }
    }
}
