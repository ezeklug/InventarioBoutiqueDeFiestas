using System;
using System.Linq;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.Ventanas;
using InventarioBoutiqueDeFiestas.Database;
using InventarioBoutiqueDeFiestas.Controladores;
using InventarioBoutiqueDeFiestas.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data;

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
//[TestMethod]
        public void testBuscarProducto()
        {
            ControladorFachada controladorFachada = new ControladorFachada();
            Console.WriteLine(controladorFachada.BuscarCategoriaPorNombre("Dulces"));
        }

        // [TestMethod]
        public void TestDtoAProducto()
        {
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

      //  [TestMethod]
        public void AplicarIncremento()
        {
            ControladorFachada fachada = new ControladorFachada();
            fachada.AplicarIncrementoTodosLosProductos(20);
        }

        //[TestMethod]
        public void InsertAgregarCliente()
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            clienteDTO.Id = 3;
            clienteDTO.Nombre = "VicTestPROBANDO";
            clienteDTO.Telefono = "unTelmod";
            clienteDTO.Email = "unEmail";
            clienteDTO.Apellido = "unApe";
            clienteDTO.Direccion = "unaDir";
            clienteDTO.Activo = true;

            ControladorCliente controladorCliente = new ControladorCliente();
            controladorCliente.AgregarModificarCliente(clienteDTO);
        }


        // [TestMethod]
        public void TestUpdateProducto()
        {
            using (var repo = new Repositorio())
            {
                var pro = repo.Productos.Find(2);
                pro.Descripcion = "una nueva descripcion";
            }
        }

        // [TestMethod]
        public void TestInsertProducto()
        {
            ProductoDTO pro = new ProductoDTO();
            pro.Id = 20;
            pro.Nombre = "Producto prueba";
            pro.Descripcion = "La nueva descripc";
            pro.StockMinimo = 10;
            pro.CantidadEnStock = 20;
            pro.PorcentajeDeGanancia = 0.8;
            pro.PrecioDeCompra = 128.98;
            pro.IdCategoria = 1;

            ControladorProducto cont = new ControladorProducto();
            Console.WriteLine("Id del producto agregado: " + cont.AgregarModificarProducto(pro).ToString());

        }


        //[TestMethod]
        public void TestListarCliente()
        {
            var con = new ControladorCliente();
            foreach(var cli in con.ListarClientes())
            {
                Console.WriteLine(cli.Id);
            }
        }

        //[TestMethod]
        public void TestListarTodosLosProductos()
        {
            ControladorProducto cont = new ControladorProducto();
            var Productos = cont.ListarTodosLosProductos();
            foreach (Producto pro in Productos)
            {
                Console.WriteLine(pro.Id);
            }
        }

       // [TestMethod]
        public void TestAgregarPresupuesto()
        {
            PresupuestoDTO pres = new PresupuestoDTO();
            pres.Id = 12;
            pres.FechaGeneracion = DateTime.Now;
            pres.FechaVencimiento = new DateTime(2021, 5, 3);
            pres.Estado = "activo";
            pres.IdCliente = 1;

            ControladorPresupuesto cont = new ControladorPresupuesto();
            Console.WriteLine("Id del presupuesto agregado es: " + cont.AgregarModificarPresupuesto(pres));

        }
        //[TestMethod]
        public void TestRemoveProducto()
        {
            using (InventarioDbContext db = new InventarioDbContext())
            {
                db.Productos.Remove(db.Productos.Find(1));
                db.SaveChanges();
            }

        }



      // [TestMethod]
        public void generarPDFHTML()
        {
            ControladorProducto cont = new ControladorProducto();
            List<Producto> pros = cont.ListarTodosLosProductos();
            string doc = File.ReadAllText("C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/List.html");
            string lista = "";

            string headers = "<tr> <th>Id</th> <th>Nombre</th> <th>Cantidad en stock</th> <th>Stock Minimo</th>  <th>Check</th> </tr>";
            foreach (var pro in pros)
            {
                lista += $"<tr><td>{pro.Id}</td><td>{pro.Nombre}</td><td>{pro.CantidadEnStock}</td> <td>{pro.StockMinimo}</td>  <td></td> </tr>\n";
            }
            doc = doc.Replace("[]", headers);
            doc = doc.Replace("{}", lista);

            string temp_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/lista_temp.html";

            File.WriteAllText(temp_file, doc);
            System.Diagnostics.Process.Start(temp_file);

        }


        //[TestMethod]
        public void testSeniarPresupuesto()
        {
            //var cont = new ControladorPresupuesto();
            //var pre = cont.BuscarPresupuesto(12);
            //Console.WriteLine(pre.TotalVenta());

            var ventana = new VSeniarPresupuesto(8, 12);
            ventana.ShowDialog();
        }

        //[TestMethod]
        public void testfecha()
        {
            Console.WriteLine(DateTime.Now + TimeSpan.FromDays(15));
        }

        //[TestMethod]
        public void TestGenPdfPresupuesto() {
            var repo = new Repositorio();
            GenPdf.PDFPresupuesto(repo.Presupuestos.Find(1));
        }

        //[TestMethod]
        public void TestGenPdf() {
            var cont = new ControladorFachada();
            GenPdf.PDFProductos(cont.ListarTodosLosProductos());
        }        

    }
}
