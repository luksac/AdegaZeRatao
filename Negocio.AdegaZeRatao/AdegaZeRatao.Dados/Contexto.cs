using Microsoft.EntityFrameworkCore;
using AdegaZeRatao.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdegaZeRatao.Dados.Configuracoes;

namespace AdegaZeRatao.Dados
{
    public class Contexto
    {
        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Respostas> Respostas { get; set; }
        public DbSet<Questionario> Questionario { get; set; }
        public DbSet<DetalhesCervejaRepositorio> DetalhesCerveja { get; set; }
        public DbSet<Cerveja> Cerveja { get; set; }
        //1. FIM

        protected void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=10.107.176.41;database=dbEcommerce;user id=visualstudio;password=visualstudio;");
        }

        protected void OnModelCreating (ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new RespostasConfiguracao());
            modelBuilder.ApplyConfiguration(new QuestionarioConfiguracao());
            modelBuilder.ApplyConfiguration(new DetalhesCervejaConfiguracao());
            modelBuilder.ApplyConfiguration(new CervejaConfiguracao());
            //2. FIM
        }
    }
}
