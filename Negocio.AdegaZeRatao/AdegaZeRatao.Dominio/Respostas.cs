using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dominio
{
    class Respostas
    {
        public int IdResposta { get; set; }
        public int IdQuestionario { get; set; }
        public int IdUsuario { get; set; }
        public Datetime DataHora { get; set; }
        public string Resposta { get; set; }
    }
}
