using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base()
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}