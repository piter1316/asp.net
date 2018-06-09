using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PPiatekHelloWorld.Models
{
    public class PPiatekHelloWorldContext : DbContext
    {
        public PPiatekHelloWorldContext (DbContextOptions<PPiatekHelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<PPiatekHelloWorld.Models.Animals> Animals { get; set; }
    }
}
