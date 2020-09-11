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
    class GenPdf
    {
        private string template_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/List.html";
        private string temp_file = "C:/Users/leo/Source/Repos/InventarioBoutiqueDeFiestas/TrabajoHP/UnitTestProject1/lista_temp.html";



        /// <summary>
        /// Abre una lista con los productos en el navevador
        /// </summary>
        /// <param name="pProductos"></param>
        public void ListarProductos(List<Producto> pProductos)
        {
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


    }
}
