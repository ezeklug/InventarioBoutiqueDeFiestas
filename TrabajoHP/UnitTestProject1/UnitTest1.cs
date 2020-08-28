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
