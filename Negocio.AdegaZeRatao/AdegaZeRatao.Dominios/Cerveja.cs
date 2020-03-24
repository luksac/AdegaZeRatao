using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdegaZeRatao.Dominios
{
    public class Cerveja
    {
        public int IdCerveja { get; set; }
        public int IdDetalhes { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }

        public bool Validar()
        {
            var listaDeCervejasHabilitadas = new[] { "Brahma", "Skol", "Devassa" };
            return listaDeCervejasHabilitadas.Contains(Categoria);
        }
    }
}
