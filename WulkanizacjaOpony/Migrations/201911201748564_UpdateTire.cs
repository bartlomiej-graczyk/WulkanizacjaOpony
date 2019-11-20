namespace WulkanizacjaOpony.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTire : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tire", "ProductionYear", c => c.Int(nullable: false));
            AddColumn("dbo.Tire", "Model", c => c.String());
            AddColumn("dbo.Tire", "ProducentCode", c => c.String());
            AddColumn("dbo.Tire", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Tire", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Tire", "ImageFileName", c => c.String());
            AddColumn("dbo.Tire", "IsHidden", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tire", "IsHidden");
            DropColumn("dbo.Tire", "ImageFileName");
            DropColumn("dbo.Tire", "Quantity");
            DropColumn("dbo.Tire", "Price");
            DropColumn("dbo.Tire", "ProducentCode");
            DropColumn("dbo.Tire", "Model");
            DropColumn("dbo.Tire", "ProductionYear");
        }
    }
}
