namespace PS2Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCoffeeImagen : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Coffees", "Imagen", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Coffees", "Imagen");
        }
    }
}
