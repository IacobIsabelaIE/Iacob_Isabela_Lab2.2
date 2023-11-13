using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Iacob_Isabela_Lab2.Models;

namespace Iacob_Isabela_Lab2.Data
{
    public class Iacob_Isabela_Lab2Context : DbContext
    {
        public Iacob_Isabela_Lab2Context(DbContextOptions<Iacob_Isabela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Iacob_Isabela_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Iacob_Isabela_Lab2.Models.Publisher> Publisher { get; set; } = default!;

        public DbSet<Iacob_Isabela_Lab2.Models.Author> Author { get; set; } = default!;

        public DbSet<Iacob_Isabela_Lab2.Models.Category> Category { get; set; } = default!;

        public DbSet<Iacob_Isabela_Lab2.Models.Member> Member { get; set; } = default!;

        public DbSet<Iacob_Isabela_Lab2.Models.Borrowing> Borrowing { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-one relationship
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Borrowing)
                .WithOne(b => b.Book)
                .HasForeignKey<Borrowing>(b => b.ID);

            // Other configurations...

            base.OnModelCreating(modelBuilder);
        }
    }
}