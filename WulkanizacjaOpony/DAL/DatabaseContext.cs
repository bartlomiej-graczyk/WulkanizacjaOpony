using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WulkanizacjaOpony.Models;

namespace WulkanizacjaOpony.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("WulkanizacjaOponyConnStr")
        {

        }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new DatabaseInitializer());
        }

        public DbSet<Tire> Tire { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}