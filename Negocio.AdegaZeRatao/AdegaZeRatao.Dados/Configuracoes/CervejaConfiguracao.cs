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
    class CervejaConfiguracao : IEntityTypeConfiguration<Cerveja>
    {
        public void Configure(EntityTypeBuilder<Cerveja> builder)
        {
            builder.ToTable("Cerveja" , "LUCAS_PAULOVICTOR");

            builder.HasKey("IdCerveja");

            builder.Property(f => f.IdCerveja).HasColumnName("IdCerveja");
            builder.Property(f => f.IdDetalhes).HasColumnName("IdDetalhes");
            builder.Property(f => f.Categoria).HasColumnName("Categoria");
            builder.Property(f => f.Tipo).HasColumnName("Tipo");

        }
    }
}
