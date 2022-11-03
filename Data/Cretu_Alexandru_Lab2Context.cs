using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cretu_Alexandru_Lab2.Models;

namespace Cretu_Alexandru_Lab2.Data
{
    public class Cretu_Alexandru_Lab2Context : DbContext
    {
        public Cretu_Alexandru_Lab2Context (DbContextOptions<Cretu_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cretu_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cretu_Alexandru_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Cretu_Alexandru_Lab2.Models.Category> Category { get; set; }
    }
}
