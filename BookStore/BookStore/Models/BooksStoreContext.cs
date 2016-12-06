using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookStore.Models.Entities;

namespace BookStore.Models
{
    public class BooksStoreContext: DbContext
    {
        public BooksStoreContext() : base("BooksStoreDBContext")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}