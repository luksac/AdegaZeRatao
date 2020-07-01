using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class AvaliacaoConfiguracao : IEntityTypeConfiguration<Avaliacao>
    {

        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("AVALIACAO", "LUCAS_PAULOVICTOR");
            //builder.ToTable("Cerveja");
            builder.HasKey("IdAvaliacao");


            builder.Property(f => f.IdCerveja).HasColumnName("IdCerveja");
            builder.Property(f => f.Comentario).HasColumnName("Comentario");
            builder.Property(f => f.Avalicao).HasColumnName("Avalicao");

        }
    }
}
