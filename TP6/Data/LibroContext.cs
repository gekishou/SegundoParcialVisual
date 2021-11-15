using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP6.Models;

namespace TP6.Data
{
    public class LibroContext : DbContext
    {
        public LibroContext (DbContextOptions<LibroContext> options)
            : base(options)
        {
        }

        public DbSet<TP6.Models.Libro> Libro { get; set; }
    }
}
