namespace InventarioBoutiqueDeFiestas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.CategoriaProductoes", "Activo", c => c.Boolean(nullable: false, defaultValue:true));
            AddColumn("public.Senias", "ValidoHasta", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
        }
        
        public override void Down()
        {
            DropColumn("public.Senias", "ValidoHasta");
            DropColumn("public.CategoriaProductoes", "Activo");
        }
    }
}
