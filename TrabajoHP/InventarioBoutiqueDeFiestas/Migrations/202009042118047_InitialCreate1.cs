namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Clientes", "Activo", c => c.Boolean(nullable: false));
            AddColumn("public.Productoes", "Activo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.Productoes", "Activo");
            DropColumn("public.Clientes", "Activo");
        }
    }
}
