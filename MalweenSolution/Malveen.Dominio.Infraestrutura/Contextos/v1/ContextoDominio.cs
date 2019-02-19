using Malveen.Dominio.Infraestrutura.Login.v1.Mapeamento;
using Malveen.Dominio.Infraestrutura.Usuarios.v1.Mapeamento;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Usuario.v1;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Malveen.Dominio.Infraestrutura.Contextos.v1
{
    public class ContextoDominio : DbContext
    {

        #region DbSets
        public virtual DbSet<UsuarioLogin> Logins { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        #endregion

        public ContextoDominio(DbContextOptions<ContextoDominio> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;
            }

            #region Configurations
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UsuarioLoginMapeamento());
            modelBuilder.ApplyConfiguration(new UsuarioMapeamento());

            #endregion
        }

    }
}
