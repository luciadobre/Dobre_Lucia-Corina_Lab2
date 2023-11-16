using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobre_Lucia_Corina_Lab2.Models;

namespace Dobre_Lucia_Corina_Lab2.Data
{
    public class Dobre_Lucia_Corina_Lab2Context : DbContext
    {
        public Dobre_Lucia_Corina_Lab2Context (DbContextOptions<Dobre_Lucia_Corina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dobre_Lucia_Corina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dobre_Lucia_Corina_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Dobre_Lucia_Corina_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Dobre_Lucia_Corina_Lab2.Models.Category>? Category { get; set; }
    }
}
