using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados
{
    public class QuestionarioRepositorio : RepositorioBase<Questionario>
    {
        public IEnumerable<Questionario> ListarTodosComEstoqueZerado()
        {
            return Contexto.Questionarios;
            //.Include(f => f.Marca)
        }

        public IEnumerable<Questionario> ListarAtivos()
        {
            return Contexto.Questionarios;
            //.Include(f => f.Marca)

        }

    }
}
