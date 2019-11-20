using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WulkanizacjaOpony.Models;

namespace WulkanizacjaOpony.DAL
{
    
    public class DatabaseInitializer : DropCreateDatabaseAlways<DatabaseContext>
    {
        //protected override void Seed(DatabaseContext context)
        //{
        //    SeedStoreData(context);

        //    base.Seed(context);
        //}

        public static void SeedStoreData(DatabaseContext context)
        {
            var tires = new List<Tire>
            {
                new Tire() { TireId = 1, Season = TireSeason.Winter, Width= 205, Profile = 55, Diameter = 16,
                    Company = "Dębica", State = TireState.New, ProductionYear = 2019, Model = "Frigo HP2",
                    ProducentCode = "531972", Price = 854, Quantity = 4, ImageFileName = "1.png", IsHidden = false },

                new Tire() { TireId = 2, Season = TireSeason.Winter, Width = 205, Profile = 55, Diameter = 16,
                    Company = "Goodride", State = TireState.New, ProductionYear = 2019, Model = "SW608",
                    ProducentCode = "", Price = 618, Quantity = 4, ImageFileName = "2.png", IsHidden = false },

                new Tire() { TireId = 3, Season = TireSeason.Winter, Width = 195, Profile = 65, Diameter = 15,
                    Company = "Ceat", State = TireState.New, ProductionYear = 2019, Model = "WINTERDRIVE",
                    ProducentCode = "", Price = 599, Quantity = 4, ImageFileName = "3.png", IsHidden = false }
            };

            tires.ForEach(g => context.Tire.AddOrUpdate(g));
            context.SaveChanges();
        }
    } 
}