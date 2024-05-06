using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using WebApplication6.Data;

namespace WebApplication6.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication6.Models.Department> Department { get; set; }

        public DbSet<Saller> Saller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
