using System;
using System.Linq;
using InventarioBoutiqueDeFiestas.Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Npgsql;


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
        public void TestGetPublicFields() {
            Producto pro = new Producto(1, "asd", "asd", 10, 9.87, null);

            Type type = pro.GetType();

            foreach (var f in type.GetFields().Where(f => f.IsPublic))
            {
                Console.WriteLine(
                    String.Format("Name: {0} Value: {1}", f.Name, f.GetValue(pro)));
            }
            Console.WriteLine("Paso por aca");
            Console.WriteLine(Producto.GetFields(BindingFlags.Public | BindingFlags.Instance));
        }
        

    }
}
