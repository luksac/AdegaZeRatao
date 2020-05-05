using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados
{
    public class RespostasRepositorio: RepositorioBase<Respostas>
    {
        public IEnumerable<Respostas> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Respostas;
            //.Include(f => f.Marca)
        }

        public IEnumerable<Respostas> ListarAtivos()
        {
            return Contexto
                .Respostas;
            //.Include(f => f.Marca)

        }
    }
}
