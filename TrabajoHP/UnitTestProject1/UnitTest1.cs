﻿using System;
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


    
        //[TestMethod]
        public void TestInsertProducto()
        {
            CategoriaProducto cat = new CategoriaProducto("Cat1", "una descripcion", false);

            Producto pro = new Producto();
            pro.Nombre = "Producto prueba";
            pro.Descripcion = "la descrip";
            pro.StockMinimo = 10;
            pro.CantidadEnStock = 20;
            pro.PorcentajeDeGanancia = 0.8;
            pro.PrecioDeCompra = 128.98;
            pro.Categoria = cat;

            using (var repo = new Repositorio())
            {
                repo.Productos.Add(pro);
            
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

    }
}
