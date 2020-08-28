using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas.Database
{
    public class InventarioDbContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<CategoriaProducto> CategoriaProductos { get; set; }
        public DbSet<LineaPresupuesto> LineaPresupuestos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<Senia> Senias { get; set; }
        public DbSet<Venta> Ventas { get; set; }


        public InventarioDbContext() : base(nameOrConnectionString: "Default")
        {
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);
        }
    }
}
