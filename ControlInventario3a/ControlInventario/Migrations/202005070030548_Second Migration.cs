namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suppliers", "SupplierCode", c => c.Int(nullable: false));
            DropColumn("dbo.Suppliers", "SpplierCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Suppliers", "SpplierCode", c => c.Int(nullable: false));
            DropColumn("dbo.Suppliers", "SupplierCode");
        }
    }
}
