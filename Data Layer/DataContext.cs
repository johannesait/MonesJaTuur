using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext(): base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, DataLayer.Migrations.Configuration>("DataContext"));
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Contact2> Contacts2 { get; set; }
    }
}