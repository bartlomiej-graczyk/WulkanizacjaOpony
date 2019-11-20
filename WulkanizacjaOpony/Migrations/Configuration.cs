namespace WulkanizacjaOpony.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WulkanizacjaOpony.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<WulkanizacjaOpony.DAL.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WulkanizacjaOpony.DAL.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.
            DatabaseInitializer.SeedStoreData(context);
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
