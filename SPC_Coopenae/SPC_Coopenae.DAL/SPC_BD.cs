using SPC_Coopenae.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<ColocacionCredito> ColocacionCredito { get; set; }
        public DbSet<ColocacionProducto> ColocacionProducto { get; set; }
        public DbSet<Ejecutivos> Ejecutivos { get; set; }
        public DbSet<MetasIDP> MetasIDP { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }
        public DbSet<TipoCredito> TipoCredito { get; set; }

    }

}
