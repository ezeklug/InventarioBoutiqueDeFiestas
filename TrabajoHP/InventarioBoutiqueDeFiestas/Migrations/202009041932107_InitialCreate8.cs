namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("public.Presupuestoes", "Estado");
            AddColumn("public.Presupuestoes", "Estado", c => c.String());
        }
        
        public override void Down()
        {
        }
    }
}
