using AdegaZeRatao.Dados.Configuracoes;
using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using System;


namespace AdegaZeRatao.Dados
{
    public class Contexto : DbContext
    {

        //1. CLASSES - ENTIDADES - TABELAS
        //1. INICIO
        public DbSet<Cerveja> Cerveja { get; set; }
        //public DbSet<Grupo> Grupo { get; set; }
        public DbSet<DetalhesCervejas> DetalhesCervejas { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<Respostas> Respostas { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        //1. FIM

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //2. DEFINIÇÃO DAS CONFIGURAÇÕES DAS CLASSES
            //2. INICIO
            modelBuilder.ApplyConfiguration(new CervejaConfiguracao());
            //modelBuilder.ApplyConfiguration(new GrupoConfiguracao());
            modelBuilder.ApplyConfiguration(new DetalheCervejaConfiguracao());
            modelBuilder.ApplyConfiguration(new QuestionarioConfiguracao());
            modelBuilder.ApplyConfiguration(new RespostasConfiguracoes());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            //modelBuilder.ApplyConfiguration(new DepartamentoConfiguracao());
            //2. FIM
        }

    }

}
