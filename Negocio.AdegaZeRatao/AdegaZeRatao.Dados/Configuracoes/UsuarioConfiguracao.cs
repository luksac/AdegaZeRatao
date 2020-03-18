using AdegaZeRatao.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdegaZeRatao.Dados.Configuracoes
{
    class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey("idUsuario");

            builder.Property(f => f.IdUsuario).HasColumnName("IdUsuario");
            builder.Property(f => f.Email).HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(f => f.Senha).HasColumnName("Senha")
                .IsRequired()
                .HasMaxLength(100);


        }
    }
}
