namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalCreate11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Presupuestoes", "Descuento", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("public.Presupuestoes", "Descuento");
        }
    }
}
