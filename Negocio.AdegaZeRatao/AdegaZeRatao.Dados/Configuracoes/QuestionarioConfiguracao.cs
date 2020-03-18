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
    class QuestionarioConfiguracao : IEntityTypeConfiguration<Questionario>
    {
        public void Configure(EntityTypeBuilder<Questionario> builder)
        {
            builder.ToTable("Questionario");

            builder.HasKey("IdQuestionario");

            builder.Property(f => f.IdQuestionario).HasColumnName("IdQuestionario");
            builder.Property(f => f.Pergunta).HasColumnName("Pergunta");
            builder.Property(f => f.DataHora).HasColumnName("DataHora");

        }

    }
}
