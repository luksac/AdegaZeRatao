using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AdegaZeRatao.Dominio;

namespace AdegaZeRatao.Dados.Configuracoes
{
    class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO", "LUCAS_PAULOVICTOR");
            //builder.ToTable("Cerveja");
            builder.HasKey("IdUsuario");
            //builder.Property(f => f.IdResposta).HasColumnName("idCerveja");
            builder.Property(f => f.Email).HasColumnName("Email");
            builder.Property(f => f.Senha).HasColumnName("Senha");
     

        }
    }
}
