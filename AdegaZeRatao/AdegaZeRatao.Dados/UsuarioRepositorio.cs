using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdegaZeRatao.Dados
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>
    {
        public IEnumerable<Usuario> ListarTodosComEstoqueZerado()
        {
            return Contexto
                .Usuario;
                //.Include(f => f.Marca)
        }

        public IEnumerable<Usuario> ListarAtivos()
        {
            return Contexto
                .Usuario;
                //.Include(f => f.Marca)
                
        }

        public IEnumerable<Usuario> ListarEmail(string email)
        {
            return Contexto.Usuario.Where(s => s.Email == email).ToList();

        }
    }
}

