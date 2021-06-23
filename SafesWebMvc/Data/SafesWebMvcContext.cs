using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SafesWebMvc.Models;

namespace SafesWebMvc.Data
{
    public class SafesWebMvcContext : DbContext
    {
        public SafesWebMvcContext (DbContextOptions<SafesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord  { get; set; }
    }
}
