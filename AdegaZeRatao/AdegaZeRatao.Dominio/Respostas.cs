using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dominio
{
    public class Respostas
    {
        public int IdUsuario{ get; set; }
        public int IdResposta { get; set; }
        public string Resposta { get; set; }
        public DateTime DataHora { get; set; }
        public int IdQuestionario { get; set; }
    }
}
