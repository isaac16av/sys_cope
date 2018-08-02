using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPC_Coopenae.DAL
{
    public class SPC_BD : DbContext
    {

        public SPC_BD() : base("name=conexion")
        {
        }

        //EF "pluraliza" los nombres de los campos, con esto lo deja de hacer, si lo hace, no encunetra las tablas de la BD
        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        //Agregar las tablas que tenga la BD
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<ColocacionCredito> ColocacionCredito { get; set; }
        public DbSet<ColocacionProducto> ColocacionProducto { get; set; }
        public DbSet<Ejecutivos> Ejecutivos { get; set; }
        public DbSet<MetasIDP> MetasIDP { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<TipoCredito> TipoCredito { get; set; }
        public DbSet<Afiliaciones> Afiliaciones { get; set; }
        public DbSet<ComisionAfiliacion> ComisionAfiliacion { get; set; }
        public DbSet<ColocacionCDP> ColocacionCDP { get; set; }
        public DbSet<TipoCDP> TipoCDP { get; set; }

    }

}
