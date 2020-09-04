namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Presupuestoes", "Estado", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Presupuestoes", "Estado");
        }
    }
}
