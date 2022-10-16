using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spacebags.Models;

namespace Spacebags.Data
{
    public class SpacebagsContext : DbContext
    {
        public SpacebagsContext (DbContextOptions<SpacebagsContext> options)
            : base(options)
        {
        }

        public DbSet<Spacebags.Models.BagsClass> BagsClass { get; set; }
    }
}
