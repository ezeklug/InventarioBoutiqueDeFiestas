using System;
using System.Linq;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.Database;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        public void TestInsert()
        {
            string TableName = "productos";
            string Campos = "";
            string connectionString = "Host=lu9jmg.no-ip.org;Username=leo;Password=leonardo;Database=pruebago";
            var con = new NpgsqlConnection(connectionString);
            string sql = "INSERT INTO localidad (descripcion) VALUES('unalocal') ";

            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteScalar();
        }

        //[TestMethod]
        public void TestLoteCreado()
        {
            using (var repo = new Repositorio())
            {
                ControladorProducto cont = new ControladorProducto();
                List<ProductoDTO> lista = new List<ProductoDTO>();
                ProductoDTO dto = new ProductoDTO();
                CategoriaProducto cat = repo.CategoriaProductos.Find(1);
                cat.Vence = true;
                dto.Nombre = "hola";
                dto.Descripcion = "";
                dto.StockMinimo = 1;
                dto.CantidadEnStock = 11;
                dto.PorcentajeDeGanancia = 0.98;
                dto.PrecioDeCompra = 100.2;
                dto.IdCategoria = cat.Id;
                lista.Add(dto);
                cont.IngresoMercarderias(lista);
            }
        }


        //[TestMethod]
        public void testDb()
        {
            InventarioDbContext inv = new InventarioDbContext();
            var cli = inv.Clientes;
            foreach (Cliente c in cli)
            {
                Console.WriteLine(cli);
            }
        }

        // [TestMethod]
        public void TestDtoAProducto() {
            ProductoDTO dto = new ProductoDTO();
            dto.Nombre = "hola";
            dto.Descripcion = "";
            dto.StockMinimo = 1;
            dto.CantidadEnStock = 11;
            dto.PorcentajeDeGanancia = 0.98;
            dto.PrecioDeCompra = 100.2;
            dto.IdCategoria = 1;
            Producto pro = new ControladorProducto().DTOAProducto(dto);
            Console.WriteLine(pro.Categoria);
            Console.WriteLine(dto.Id);
            Console.WriteLine(new Producto().Id);
        }



       // [TestMethod]
        public void TestUpdateProducto()
        {
            using (var repo = new Repositorio()) {
                var pro = repo.Productos.Find(2);
                pro.Descripcion = "una nueva descripcion";
            }
        }
    
        [TestMethod]
        public void TestInsertProducto()
        {

            CategoriaProducto cat = new CategoriaProducto("Luces", "luces de fiesta", false);
            Producto pro = new Producto();
            pro.Id = 1;
            pro.Nombre = "Producto prueba";
            pro.Descripcion = "asdasdas";
            pro.StockMinimo = 10;
            pro.CantidadEnStock = 20;
            pro.PorcentajeDeGanancia = 0.8;
            pro.PrecioDeCompra = 128.98;
            pro.Categoria = cat;

            using (var repo = new Repositorio())
            {
                //pro.Categoria = repo.CategoriaProductos.Find(1);
                repo.Productos.Attach(pro);
                //repo.Productos.Add(pro);
            }
        }


        //[TestMethod]
        public void TestRemoveProducto() {
            using (InventarioDbContext db = new InventarioDbContext())
            {
                db.Productos.Remove(db.Productos.Find(1));
                db.SaveChanges();
            }


        }
        //[TestMethod]
        public void TestDTOASenia()
        {
            using (Repositorio repo = new Repositorio())
            {
                Presupuesto pito = new Presupuesto();
                pito.Cliente = null;
                pito.FechaEvento = DateTime.Now;
                repo.Presupuestos.Add(pito);
            }
            SeniaDTO sen = new SeniaDTO();
            sen.Fecha = DateTime.Now;
            sen.Monto = 120;
            sen.IdPresupuesto = 1;

            new ControladorPresupuesto().DTOASenia(sen);
        }


    }
}
