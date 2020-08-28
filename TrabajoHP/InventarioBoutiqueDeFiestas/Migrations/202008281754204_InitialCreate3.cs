namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        StockMinimo = c.Int(nullable: false),
                        CantidadEnStock = c.Int(nullable: false),
                        PorcentajeDeGanancia = c.Double(nullable: false),
                        PrecioDeCompra = c.Double(nullable: false),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.CategoriaProductoes", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
            CreateTable(
                "public.CategoriaProductoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Vence = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("public.Clientes", "Telefono", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("public.Productoes", "Categoria_Id", "public.CategoriaProductoes");
            DropIndex("public.Productoes", new[] { "Categoria_Id" });
            AlterColumn("public.Clientes", "Telefono", c => c.Int(nullable: false));
            DropTable("public.CategoriaProductoes");
            DropTable("public.Productoes");
        }
    }
}
