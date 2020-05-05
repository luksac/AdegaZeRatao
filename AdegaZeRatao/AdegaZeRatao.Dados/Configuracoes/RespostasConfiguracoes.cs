using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    class RespostasConfiguracoes : IEntityTypeConfiguration<Respostas>
    {
        public void Configure(EntityTypeBuilder<Respostas> builder)
        {
            builder.ToTable("RESPOSTAS", "LUCAS_PAULOVICTOR");
            builder.HasKey("IdResposta");
            builder.Property(f => f.IdQuestionario).HasColumnName("IdQuestionario");
            builder.Property(f => f.IdUsuario).HasColumnName("IdUsuario");
            builder.Property(f => f.DataHora).HasColumnName("DataHora");
            builder.Property(f => f.Resposta).HasColumnName("Resposta");

        }
    }
}
