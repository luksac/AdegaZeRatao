using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class CervejaRepositorio : RepositorioBase<Cerveja>
    {
        public IEnumerable<Cerveja> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Cerveja
                //.Include(f => f.Marca)
                .Where(f => f.IdDetalhes == 0);
        }

        public IEnumerable<Cerveja> ListarAtivos()
        {
            return Contexto
                .Cerveja
                //.Include(f => f.Marca)
                .ToList();
        }
    }

}
