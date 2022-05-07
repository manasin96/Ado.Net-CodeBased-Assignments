using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootballCodebased.Models
{
    public class FootballContext: DbContext
    {
        public FootballContext() : base("name=DBCS")
        {

        }
        public DbSet<Football> FootBalls { get; set; }
    }
}