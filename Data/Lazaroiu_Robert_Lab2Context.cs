using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lazaroiu_Robert_Lab2.Models;

namespace Lazaroiu_Robert_Lab2.Data
{
    public class Lazaroiu_Robert_Lab2Context : DbContext
    {
        public Lazaroiu_Robert_Lab2Context (DbContextOptions<Lazaroiu_Robert_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lazaroiu_Robert_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Lazaroiu_Robert_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Lazaroiu_Robert_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Lazaroiu_Robert_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
