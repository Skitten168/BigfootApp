using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bigfoot.Models;

namespace Bigfoot.Data
{
    public class BigfootContext : DbContext
    {
        public BigfootContext (DbContextOptions<BigfootContext> options)
            : base(options)
        {
        }

        public DbSet<Bigfoot.Models.Sightings> Sightings { get; set; } = default!;

    }
}
