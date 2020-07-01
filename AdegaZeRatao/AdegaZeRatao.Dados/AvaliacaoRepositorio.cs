using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdegaZeRatao.Dados
{
    public class AvaliacaoRepositorio : RepositorioBase<Avaliacao>
    {
        public IEnumerable<Avaliacao> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Avaliacao
                //.Include(f => f.Marca)
                .Where(f => f.IdAvaliacao == 0);
        }

        public IEnumerable<Avaliacao> ListarAtivos()
        {


            return Contexto
                .Avaliacao
                //.Include(f => f.Marca)
                .ToList();
        }

        public IEnumerable<Avaliacao> Listar(int IdCerveja)
        {
            return Contexto.Avaliacao.Where(f => f.IdCerveja == IdCerveja).ToList();
        }
    }
}
