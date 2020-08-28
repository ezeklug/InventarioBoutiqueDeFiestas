namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.LineaPresupuestoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        PorcentajeDescuento = c.Double(nullable: false),
                        Subtotal = c.Double(nullable: false),
                        Presupuesto_Id = c.Int(),
                        Producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Presupuestoes", t => t.Presupuesto_Id)
                .ForeignKey("public.Productoes", t => t.Producto_Id)
                .Index(t => t.Presupuesto_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "public.Presupuestoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaGeneracion = c.DateTime(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                        FechaEntrega = c.DateTime(nullable: false),
                        FechaEvento = c.DateTime(nullable: false),
                        Cliente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Clientes", t => t.Cliente_Id)
                .Index(t => t.Cliente_Id);
            
            CreateTable(
                "public.Lotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CantidadProductos = c.Int(nullable: false),
                        FechaCompra = c.DateTime(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                        Vencido = c.Boolean(nullable: false),
                        Producto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Productoes", t => t.Producto_Id)
                .Index(t => t.Producto_Id);
            
            CreateTable(
                "public.Senias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Monto = c.Double(nullable: false),
                        Presupuesto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Presupuestoes", t => t.Presupuesto_Id)
                .Index(t => t.Presupuesto_Id);
            
            CreateTable(
                "public.Ventas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaDeVenta = c.DateTime(nullable: false),
                        Presupuesto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Presupuestoes", t => t.Presupuesto_Id)
                .Index(t => t.Presupuesto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Ventas", "Presupuesto_Id", "public.Presupuestoes");
            DropForeignKey("public.Senias", "Presupuesto_Id", "public.Presupuestoes");
            DropForeignKey("public.Lotes", "Producto_Id", "public.Productoes");
            DropForeignKey("public.LineaPresupuestoes", "Producto_Id", "public.Productoes");
            DropForeignKey("public.LineaPresupuestoes", "Presupuesto_Id", "public.Presupuestoes");
            DropForeignKey("public.Presupuestoes", "Cliente_Id", "public.Clientes");
            DropIndex("public.Ventas", new[] { "Presupuesto_Id" });
            DropIndex("public.Senias", new[] { "Presupuesto_Id" });
            DropIndex("public.Lotes", new[] { "Producto_Id" });
            DropIndex("public.Presupuestoes", new[] { "Cliente_Id" });
            DropIndex("public.LineaPresupuestoes", new[] { "Producto_Id" });
            DropIndex("public.LineaPresupuestoes", new[] { "Presupuesto_Id" });
            DropTable("public.Ventas");
            DropTable("public.Senias");
            DropTable("public.Lotes");
            DropTable("public.Presupuestoes");
            DropTable("public.LineaPresupuestoes");
        }
    }
}
