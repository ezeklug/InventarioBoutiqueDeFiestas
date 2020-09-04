using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas.Database
{

    /// <summary>
    /// Proporiciona una conexion a la base de datos para hacer consulta a los repositorios
    /// Mezcla patron repository y unit of work
    /// </summary>
    public class Repositorio : IDisposable
    {
        private bool iDisposedValue = false;
        private InventarioDbContext db;
        
        
        protected virtual void Dispose(bool pDisposing)
        {
            if (!this.iDisposedValue)
            {
                if (pDisposing)
                {
                    this.db.Dispose();
                }
                this.iDisposedValue = true;
            }
        }

        public void Dispose()
        {
            this.db.SaveChanges();
            this.Dispose(true);
        }


        public void Complete()
        {
            this.db.SaveChanges();
        }

        public void SaveChanges()
        {
            this.db.SaveChanges();
        }
        public DbSet<Cliente> Clientes { get; private set; }
        public DbSet<Producto> Productos { get; private set; }
        public DbSet<CategoriaProducto> CategoriaProductos { get; private set; }
        public DbSet<LineaPresupuesto> LineaPresupuestos { get; private set; }
        public DbSet<Lote> Lotes { get; private set; }
        public DbSet<Presupuesto> Presupuestos { get; private set; }
        public DbSet<Senia> Senias { get; private set; }
        public DbSet<Venta> Ventas { get; private set; }



        public Repositorio() {
            db = new InventarioDbContext();
            Clientes = db.Clientes;
            Productos = db.Productos;
            CategoriaProductos = db.CategoriaProductos;
            LineaPresupuestos = db.LineaPresupuestos;
            Lotes = db.Lotes;
            Presupuestos = db.Presupuestos;
            Senias = db.Senias;
            Ventas = db.Ventas;
        }

    }
}
