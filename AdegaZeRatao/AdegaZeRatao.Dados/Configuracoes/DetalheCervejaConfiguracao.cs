using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class DetalheCervejaConfiguracao :  IEntityTypeConfiguration<DetalhesCervejas>
    {
        public void Configure(EntityTypeBuilder<DetalhesCervejas> builder)
        {
            builder.ToTable("DETALHESCERVEJAS", "LUCAS_PAULOVICTOR");
            //builder.ToTable("DetalhesCervejas");
            builder.HasKey("IdDetalhe");
            //builder.Property(f => f.IdDetalhe).HasColumnName("idDetalhe");
            builder.Property(f => f.PrecoSugerido).HasColumnName("PrecoSugerido");
            builder.Property(f => f.ProdutoQuantidade).HasColumnName("ProdutoQuantidade");
            builder.Property(f => f.Ranking).HasColumnName("Ranking");
 
        }
    }
}
