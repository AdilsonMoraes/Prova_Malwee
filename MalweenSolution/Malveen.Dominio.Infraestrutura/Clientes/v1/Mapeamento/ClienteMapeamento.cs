using Malween.Dominio.Cliente.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.Clientes.v1.Mapeamento
{
    public class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(k => k.Id);

            builder.Property(h => h.Id)
                .HasColumnName("id_cliente")
                .IsRequired();

            builder.Property(h => h.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(h => h.Bairro)
                .HasColumnName("bairro")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(h => h.Cidade)
                .HasColumnName("cidade")
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(h => h.Estado)
                .HasColumnName("estado")
                .HasMaxLength(100)
                .IsUnicode(false);
    }
    }
}
