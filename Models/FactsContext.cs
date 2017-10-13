using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aminofakeApi.Models
{
    public class FactsContext : DbContext
    {
        public FactsContext(DbContextOptions<FactsContext> options)
            : base(options)
        { }

        public DbSet<Fact> Facts { get; set; }
    }
}
