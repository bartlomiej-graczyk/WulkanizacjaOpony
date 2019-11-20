using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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

    }
}