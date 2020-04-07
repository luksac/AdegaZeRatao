﻿using AdegaZeRatao.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdegaZeRatao.Dados
{
    public class DetalhesCervejaRepositorio : RepositorioBase<DetalhesCerveja>
    {
        public IEnumerable<DetalhesCerveja> ListaDetalhesCerveja()
        {
            return ListarTodos();
        }
    }
}
