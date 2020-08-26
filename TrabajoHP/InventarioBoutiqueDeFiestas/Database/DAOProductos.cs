using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioBoutiqueDeFiestas.Dominio;
using Npgsql;

namespace InventarioBoutiqueDeFiestas.Database
{
    class DAOProductos : IOperacionesDB<Producto>
    {
        static string TableName = "productos";
        static string Campos = "id,nombre,descripcion,stockminimo,cantidadenstock,procentajedeganancia,preciodecompra,categoria"

        public void Eliminar(int id)
        {
            var con = new NpgsqlConnection(Config.connectionString);
            string sql = "DELETE FROM " + TableName + " WHERE id=" + id.ToString();

            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteScalar();
        }

        public bool Existe(int pId)
        {
            throw new NotImplementedException();
        }

        public bool Insertar(Producto pTentity)
        {
            var con = new NpgsqlConnection(Config.connectionString);
            string datos = pTentity.Id.ToString() + "," + pTentity.Nombre.ToString() + "," + pTentity.Descripcion.ToString() + "," + pTentity.StockMinimo.ToString() + "," +
                pTentity.CantidadEnStock.ToString() + "," + pTentity.PorcentajeDeGanancia.ToString() + "," + pTentity.PrecioDeCompra.ToString() + "," +
                pTentity.CantidadEnStock.ToString() + "," + pTentity.Categoria.Id.ToString();
              string sql = "INSERT INTO "+TableName+" ("+Campos+") VALUES() ";

            con.Open();
            var cmd = new NpgsqlCommand(sql, con);
            cmd.ExecuteScalar();
            return false;
        }

        public void Modificar(Producto pTentity)
        {
            throw new NotImplementedException();
        }

        public Producto Obtener(int pId)
        {
            throw new NotImplementedException();
        }

        public Producto Obtener(string iCampo, string pId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
