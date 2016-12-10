using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;
using BookStore.Migrations.Entities;

namespace BookStore.Models
{
    public class BooksStoreContext : DbContext
    {
        public BooksStoreContext() : base("BooksStoreDBContext")
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOptional(i => i.Image)
                .WithOptionalPrincipal(b => b.Book);
        }
    }
}