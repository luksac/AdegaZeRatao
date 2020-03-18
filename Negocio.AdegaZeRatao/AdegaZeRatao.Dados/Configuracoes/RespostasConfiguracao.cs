using AdegaZeRatao.Dominios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class RespostasConfiguracao : IEntityTypeConfiguration<Respostas>
    {
        public void Configure(EntityTypeBuilder<Respostas> builder)
        {
            builder.ToTable("Respostas");

            builder.HasKey("IdResposta");

            builder.Property(f => f.IdResposta).HasColumnName("IdResposta");
            builder.Property(f => f.IdQuestionario).HasColumnName("IdQuestionario");
            builder.Property(f => f.IdUsuario).HasColumnName("IdUsuario");
            builder.Property(f => f.DataHora).HasColumnName("DataHora");
            builder.Property(f => f.Resposta).HasColumnName("Resposta");

        }
    }
}
