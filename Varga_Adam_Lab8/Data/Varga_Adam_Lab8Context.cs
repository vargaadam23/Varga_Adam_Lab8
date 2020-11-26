using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Varga_Adam_Lab8.Models;

namespace Varga_Adam_Lab8.Data
{
    public class Varga_Adam_Lab8Context : DbContext
    {
        public Varga_Adam_Lab8Context (DbContextOptions<Varga_Adam_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Varga_Adam_Lab8.Models.Book> Book { get; set; }

        public DbSet<Varga_Adam_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Varga_Adam_Lab8.Models.Category> Category { get; set; }
    }
}
