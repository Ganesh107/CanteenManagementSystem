using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CanteenManagement.Models
{
    public class CanteenContext : DbContext
    {
        public CanteenContext() : base("name=Dbconn")
        {

        }
        public DbSet<SouthIndian> southIndian { get; set; }
        public DbSet<NorthIndian> northIndian { get; set; }
        public DbSet<Chinese> chinese { get; set; }
        public DbSet<Deserts> deserts { get; set; }
        public DbSet<Beverages> beverages { get; set; }
    }
}