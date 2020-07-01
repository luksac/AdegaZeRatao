using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Reflection;

namespace AdegaZeRatao.Dominio
{
    public class Cerveja
    {
        public int IdCerveja { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public int IdDetalhes { get; set; }
        public string Descricao { get; set; }

        public DetalhesCervejas Detalhes { get; set; }
        public string Foto { get; set; }



    }
}
