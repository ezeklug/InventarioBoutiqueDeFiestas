using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;

namespace InventarioBoutiqueDeFiestas.Controladores
{

    /// <summary>
    /// Clase de utilidad para transformar listas en pdf
    /// </summary>
    public class GenPdf
    {

        private static string temp_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/temp.html";


        /// <summary>
        /// Abre una lista con los productos en el navevador
        /// </summary>
        /// <param name="pProductos"></param>
        public static void  PDFProductos(List<Producto> pProductos)
        {
            string template_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/TemplateProductos.html";

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
            string template_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/TemplatePresupuesto.html";


            string doc = File.ReadAllText(template_file);
            string headers = "<tr>  <th>Nombre</th> <th>Cantidad</th> <th>Precio unitario</th> <th>Subtotal</th> </tr>";
            string lista = "";

            foreach(var linea in pPresupuesto.Lineas)
            {
                lista += $"<tr> <th> {linea.Producto.Nombre} </th> <th> {linea.Cantidad} </th> <th> {linea.Producto.PrecioVenta()} </th> <th> {linea.Subtotal} </th></tr>";
            }

            doc = doc.Replace("[]", headers);
            doc = doc.Replace("{}", lista);
            doc = doc.Replace("PesosTotal", pPresupuesto.TotalVenta().ToString());
            File.WriteAllText(temp_file, doc);
            System.Diagnostics.Process.Start(temp_file);

        }



    }
}
