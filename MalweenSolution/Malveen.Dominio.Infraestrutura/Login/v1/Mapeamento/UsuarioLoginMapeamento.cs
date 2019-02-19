using Malween.Dominio.Login.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.Login.v1.Mapeamento
{
    public class UsuarioLoginMapeamento : IEntityTypeConfiguration<UsuarioLogin>
    {
        public void Configure(EntityTypeBuilder<UsuarioLogin> builder)
        {
            builder.ToTable("USUARIO_LOGIN");

            builder.HasKey(p => p.Usuario);

            builder.Property(h => h.Usuario)
                .HasColumnName("NOME_USUARIO")
                .IsUnicode(false)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(h => h.Senha)
                .HasColumnName("SENHA")
                .IsUnicode(false)
                .IsRequired();

            builder.Property(h => h.TokenAuth)
                .HasColumnName("IsAdministrator")
                .IsUnicode(false);

            builder.Property(h => h.TokenAuth)
                .HasColumnName("TokenAuth")
                .IsUnicode(false);
        }
    }
}
