using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class Parcial2Db : DbContext
    {
        public Parcial2Db() : base("name = conStr")
        {

        }

        public virtual DbSet<Clientes> Cliente { get; set; }
        public virtual DbSet<TiposTelefonos> TipoTelefono { get; set; }
        public virtual DbSet<ClientesTelefonos> ClienteTelefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                .HasMany<Clientes>(g => g.Clientes)
                .WithMany(e => e.Telefono)
                .Map(ge =>
                {
                    ge.MapLeftKey("ClienteId");
                    ge.MapRightKey("TipoId");
                    ge.ToTable("ClientesTelefonos");
                });
        }

    }
}
