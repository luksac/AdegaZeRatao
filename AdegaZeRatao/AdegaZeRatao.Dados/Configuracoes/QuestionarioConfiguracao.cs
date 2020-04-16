using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class QuestionarioConfiguracao : IEntityTypeConfiguration<Questionario>
    {
        public void Configure(EntityTypeBuilder<Questionario> builder)
        {
            builder.ToTable("QUESTIONARIO", "LUCAS_PAULOVICTOR");
            //builder.ToTable("Cerveja");
            builder.HasKey("IdQuestionario");
            //builder.Property(f => f.IdQuestionario).HasColumnName("idCerveja");
            builder.Property(f => f.Pergunta).HasColumnName("IdDetalhes");
            builder.Property(f => f.MyProperty).HasColumnName("Categoria");

        }
    }
}
