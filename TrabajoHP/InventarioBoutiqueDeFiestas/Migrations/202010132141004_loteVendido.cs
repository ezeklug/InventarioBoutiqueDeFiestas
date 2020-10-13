namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class loteVendido : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.LoteVendidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        Lote_Id = c.Int(),
                        Venta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("public.Lotes", t => t.Lote_Id)
                .ForeignKey("public.Ventas", t => t.Venta_Id)
                .Index(t => t.Lote_Id)
                .Index(t => t.Venta_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.LoteVendidoes", "Venta_Id", "public.Ventas");
            DropForeignKey("public.LoteVendidoes", "Lote_Id", "public.Lotes");
            DropIndex("public.LoteVendidoes", new[] { "Venta_Id" });
            DropIndex("public.LoteVendidoes", new[] { "Lote_Id" });
            DropTable("public.LoteVendidoes");
        }
    }
}
