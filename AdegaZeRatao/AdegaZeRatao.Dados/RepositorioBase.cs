using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public abstract class RepositorioBase<T> where T : class
    {
         protected Contexto Contexto { get; }
         private DbSet<T> Entidade { get; }

         public RepositorioBase()
         {
             Contexto = new Contexto();
             Entidade = Contexto.Set<T>();
         }

         public T ListarUm(int keys)
         {
            return Entidade.Find(keys);
            //return Entidade.Select(keys);
         }

         public List<T> ListarTodos()
         {
             return Contexto
                 .Set<T>()
                 .ToList();
         }

         public void Adicionar(T entidade)
         {
             Entidade.Add(entidade);
             Contexto.SaveChanges();
         }

         public void Remover(T entidade)
         {
             Entidade.Remove(entidade);
             Contexto.SaveChanges();
         }

         public void Atualizar(T entidade)
         {
             Entidade.Update(entidade);
             Contexto.SaveChanges();
         }

        public string Validar(Usuario entidade)
        {
          
             if(Entidade.Find(entidade.Email) !=null && Entidade.Find(entidade.Senha) != null)
             {
                return "OK";
             }
            else
            {
                return "Tente Novamente";
            }

        }



    }
    
}
