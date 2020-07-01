using AdegaZeRatao.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdegaZeRatao.Dados.Configuracoes
{
    public class CervejaConfiguracao : IEntityTypeConfiguration<Cerveja>
    {
     
        public void Configure(EntityTypeBuilder<Cerveja> builder)
        {
            builder.ToTable("CERVEJA", "LUCAS_PAULOVICTOR");
            //builder.ToTable("Cerveja");
            builder.HasKey("IdCerveja");

            //builder.HasOne(b => b.Detalhes).WithMany().HasForeignKey(f => f.IdDetalhes);
            

            builder.Property(f => f.IdDetalhes).HasColumnName("IdDetalhes");
            builder.Property(f => f.Categoria).HasColumnName("Categoria");
            builder.Property(f => f.Tipo).HasColumnName("Tipo");
            builder.Property(f => f.Descricao).HasColumnName("Descricao");
            builder.Property(f => f.Foto).HasColumnName("FOTO");

            //builder
            //   .HasOne(d => d.Marca)
            //   .WithMany()
            //   .HasForeignKey(f => f.idMarca);

        }




    }
}
