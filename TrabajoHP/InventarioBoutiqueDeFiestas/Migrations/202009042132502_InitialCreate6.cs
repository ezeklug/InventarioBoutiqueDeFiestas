namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("public.Productoes", "Activo", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("public.Productoes", "Activo", c => c.Boolean(nullable: false));
        }
    }
}
