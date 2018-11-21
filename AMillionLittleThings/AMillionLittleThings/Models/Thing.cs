using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AMillionLittleThings.Models
{
    public class Thing
    {
        public int NameID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ThingDbContext : DbContext
    {
        public DbSet<Thing> Things { get; set; }
    }
}