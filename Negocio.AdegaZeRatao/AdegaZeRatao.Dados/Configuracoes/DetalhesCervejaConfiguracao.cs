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
    class DetalhesCervejaConfiguracao : IEntityTypeConfiguration<DetalhesCervejaRepositorio>
    {
        public void Configure(EntityTypeBuilder<DetalhesCervejaRepositorio> builder)
        {
            builder.ToTable("DetalhesCerveja");

            builder.HasKey("IdDetalhe");

            builder.Property(f => f.IdDetalhe).HasColumnName("IdDetalhe");
            builder.Property(f => f.Ranking).HasColumnName("Ranking");
            builder.Property(f => f.PreçoSugerido).HasColumnName("PreçoSugerido");
            builder.Property(f => f.ProdutoQuantidade).HasColumnName("ProdutoQuantidade");

        }
    }
}
