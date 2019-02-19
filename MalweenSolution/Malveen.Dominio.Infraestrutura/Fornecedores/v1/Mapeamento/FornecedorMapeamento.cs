using Malween.Dominio.Fornecedor.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.Fornecedores.v1.Mapeamento
{
    public class FornecedorMapeamento : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(k => k.Id);

            builder.Property(h => h.Id)
                .HasColumnName("id_fornecedor")
                .IsRequired();

            builder.Property(h => h.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
