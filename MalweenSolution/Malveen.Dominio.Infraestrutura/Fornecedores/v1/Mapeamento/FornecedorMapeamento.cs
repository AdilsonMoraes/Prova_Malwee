using Malween.Dominio.Fornecedores.v1;
using Malween.Dominio.Usuarios.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Malveen.Dominio.Infraestrutura.Fornecedores.v1.Mapeamento
{
    public class FornecedorMapeamento : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasOne(o => o.Usuario)
                .WithOne(w => w.Fornecedor)
                .HasForeignKey<Usuario>(f => f.Id);

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
