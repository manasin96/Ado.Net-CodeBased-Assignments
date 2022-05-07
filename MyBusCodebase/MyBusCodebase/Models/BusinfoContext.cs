using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MyBusCodebase.Models
{
    public class BusinfoContext: DbContext
    {
        public BusinfoContext() : base("name=BusConnection")
        {

        }
        public DbSet<BusinfoClass> businfos { get; set; } //to map into db
    }
}
