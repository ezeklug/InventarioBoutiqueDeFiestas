using System;
using System.Linq;
using InventarioBoutiqueDeFiestas.Dominio;
using InventarioBoutiqueDeFiestas.Database;
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

      //  [TestMethod]
        public void TestReflecion() 
        {
            Producto pro = new Producto(1,"asd","asd",10,9.87,null);
            System.Reflection.PropertyInfo pi = pro.GetType().GetProperty("Id");
            int id = (int)pi.GetValue(pro, null);
            Console.WriteLine("El id es: "+id.ToString());

        }


        [TestMethod]
        public void testDb()
        {
            InventarioDbContext inv = new InventarioDbContext();
            var cli = inv.Clientes;
            foreach(Cliente c in cli)
            {
                Console.WriteLine(cli);
            }
        }

        

    }
}
