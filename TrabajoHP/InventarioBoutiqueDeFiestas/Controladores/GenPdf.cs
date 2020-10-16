using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.DTO;

namespace InventarioBoutiqueDeFiestas.Controladores
{

    /// <summary>
    /// Clase de utilidad para transformar listas en pdf
    /// </summary>
    public class GenPdf
    {
        /// <summary>
        /// Prefix es el prefijo de cada computadora
        /// Cambiarlo para cada pc
        /// </summary>
        private static string prefix = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/";
        private static string temp_file = prefix+"temp.html";


        /// <summary>
        /// Abre una lista con los productos en el navevador
        /// </summary>
        /// <param name="pProductos"></param>
        public static void  PDFProductos(List<ProductoDTO> pProductos)
        {
            string template_file = prefix+"TemplateProductos.html";

            string doc = File.ReadAllText(template_file);
            string headers = "<tr> <th>Id</th> <th>Nombre</th> <th>Cantidad en stock</th> <th>Stock Minimo</th> <th>Check</th> </tr>";
            string lista = "";
            foreach (var pro in pProductos)
            {
                lista += $"<tr><td>{pro.Id}</td><td>{pro.Nombre}</td><td>{pro.CantidadEnStock}</td> <td>{pro.StockMinimo}</td> <td></td> </tr>\n";
            }

            doc = doc.Replace("[]", headers);
            doc = doc.Replace("{}", lista);

            File.WriteAllText(temp_file, doc);
            System.Diagnostics.Process.Start(temp_file);
        }

        public static void PDFPresupuesto(Presupuesto pPresupuesto) {
            string template_file =prefix+"TemplatePresupuesto.html";


            string doc = File.ReadAllText(template_file);
            string headers = "<tr>  <th>Nombre</th> <th>Cantidad</th> <th>Precio unitario</th> <th>Subtotal</th> </tr>";
            string lista = "";

            foreach(var linea in pPresupuesto.Lineas)
            {
                lista += $"<tr> <td> {linea.Producto.Nombre} </td> <th> {linea.Cantidad} </td> <td> {linea.Producto.PrecioVenta()} </td> <td> {linea.Subtotal} </td></tr>";
            }

            doc = doc.Replace("[]", headers);
            doc = doc.Replace("{}", lista);
            doc = doc.Replace("PesosTotal", pPresupuesto.TotalVenta().ToString());
            File.WriteAllText(temp_file, doc);
            System.Diagnostics.Process.Start(temp_file);

        }

        public static void PDFClientes(ICollection<ClienteDTO> pClientes)
        {
            string template_file = prefix+"TemplateClientes.html";


            string doc = File.ReadAllText(template_file);
            string headers = "<tr>  <th>Nombre</th> <th>Apellido</th> <th>Telefono</th> <th>Direccion</th> </tr>";
            string lista = "";

            foreach (var cli in pClientes)
            {
                lista += $"<tr> <td> {cli.Nombre} </td> <td> {cli.Apellido} </td> <td> {cli.Telefono} </td> <td> {cli.Direccion} </td></tr>";
            }

            doc = doc.Replace("[]", headers);
            doc = doc.Replace("{}", lista);
            doc = doc.Replace("PesosTotal", "");
            File.WriteAllText(temp_file, doc);
            System.Diagnostics.Process.Start(temp_file);
        }

    }
}
