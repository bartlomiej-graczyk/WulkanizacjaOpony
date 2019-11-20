using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WulkanizacjaOpony.DAL
{
    public class DatabaseInitializer : MigrateDatabaseToLatestVersion<DatabaseContext, Configuration>
    {
        //protected override void Seed(DatabaseContext context)
        //{
        //    InitializeIdentityForEF(context);
        //    SeedStoreData(context);

        //    base.Seed(context);
        //}

        public static void SeedStoreData(DatabaseContext context)
        {
            //var genres = new List<Genre>
            //{
            //    new Genre() { GenreId = 1, Name = "Rock", IconFilename = "rock.png" },
            //    new Genre() { GenreId = 2, Name = "Metal", IconFilename = "metal.png" },
            //    new Genre() { GenreId = 3, Name = "Jazz", IconFilename = "jazz.png" },
            //    new Genre() { GenreId = 4, Name = "Hip Hop", IconFilename = "hiphop.png" },
            //    new Genre() { GenreId = 5, Name = "R&B", IconFilename = "rnb.png" },
            //    new Genre() { GenreId = 6, Name = "Pop", IconFilename = "pop.png" },
            //    new Genre() { GenreId = 7, Name = "Reggae", IconFilename = "reagge.png" },
            //    new Genre() { GenreId = 8, Name = "Alternative", IconFilename = "alternative.png" },
            //    new Genre() { GenreId = 9, Name = "Electronic", IconFilename = "electro.png" },
            //    new Genre() { GenreId = 10, Name = "Classical", IconFilename = "classics.png" },
            //    new Genre() { GenreId = 11, Name = "Inne", IconFilename = "other.png" },
            //    new Genre() { GenreId = 12, Name = "Promocje", IconFilename = "promos.png" }
            //};

            //genres.ForEach(g => context.Genres.AddOrUpdate(g));
            //context.SaveChanges();


        }
    }