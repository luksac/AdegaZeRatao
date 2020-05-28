using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdegaZeRatao.Dados
{
    public class DetalhesCervejaRepositorio : RepositorioBase<DetalhesCervejas>
    {
        public IEnumerable<DetalhesCervejas> ListarTodosComEstoqueZerado()
        {
            return Contexto.DetalhesCervejas;
            //.Include(f => f.Marca)
        }

        public IEnumerable<DetalhesCervejas> ListarAtivos()
        {
            return Contexto.DetalhesCervejas.ToList(); 
            //.Include(f => f.Marca)

        }

        public DetalhesCervejas Listar1(int IdDetalhes)
        {
            return Contexto.DetalhesCervejas.Find(IdDetalhes);
        }




    }
}
