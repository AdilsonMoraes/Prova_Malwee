using Malween.Dominio.Fornecedores.v1;
using Malween.Dominio.Usuarios.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Malveen.Dominio.Infraestrutura.Usuarios.v1.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");

            builder.HasKey(k => k.Id);
            builder.Ignore(b => b.Token);

            builder.Property(h => h.Id)
                .HasColumnName("id_usuario")
                .IsRequired();

            builder.Property(h => h.Email)
                .HasColumnName("email")
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(h => h.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsUnicode(false);
        }
    }
}
