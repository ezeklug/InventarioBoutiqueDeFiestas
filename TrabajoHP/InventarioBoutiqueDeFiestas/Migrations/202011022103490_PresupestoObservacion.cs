namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PresupestoObservacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Presupuestoes", "Observacion", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Presupuestoes", "Observacion");
        }
    }
}
