namespace WulkanizacjaOpony.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Start : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tire",
                c => new
                    {
                        TireId = c.Int(nullable: false, identity: true),
                        Season = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Profile = c.Int(nullable: false),
                        Diameter = c.Int(nullable: false),
                        Company = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TireId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tire");
        }
    }
}
