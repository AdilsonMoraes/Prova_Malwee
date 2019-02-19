using Malveen.Dominio.Infraestrutura.Login.Mapeamento;
using Malween.Dominio.Login.v1;
using Malween.Dominio.Usuario.v1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Malveen.Dominio.Infraestrutura.Contextos
{
    public class ContextoDominio : DbContext
    {

        #region DbSets
        public virtual DbSet<UsuarioLogin> Logins { get; set; }
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

            #endregion
        }

    }
}
