using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BookStore.Models.Entities;

namespace BookStore.Models
{
    public class BooksRepository : IBooksRepository, IDisposable
    {
        private readonly BooksStoreContext _context = new BooksStoreContext();
        private bool _disposed = false;

        public IEnumerable<Book> GetBooks()
        {
            //var books = new List<Book>
            //{
            //    new Book { Name = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", Price = 25, Genre = "Fantasy", BookCover = new Image {Path = "~/Resources/Images/harry-potter1.png"} },
            //    //new Book { Name = "Harry Potter and the Chamber of Secrets", Author = "J. K. Rowling", Price = 25, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "Harry Potter and the Prisoner of Azkaban", Author = "J. K. Rowling", Price = 30, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "Harry Potter and the Goblet of Fire", Author = "J. K. Rowling", Price = 30, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "Harry Potter and the Order of the Phoenix", Author = "J. K. Rowling", Price = 35, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "Harry Potter and the Half-Blood Prince", Author = "J. K. Rowling", Price = 40, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "Harry Potter and the Deathly Hallows", Author = "J. K. Rowling", Price = 40, Genre = "Fantasy", BookCover = null },
            //    //new Book { Name = "The Lord of the Rings: The Fellowship of the Ring", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
            //    //new Book { Name = "The Lord of the Rings: The Two Towers", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
            //    //new Book { Name = "The Lord of the Rings: The Return of the King", Author = "J. R. R. Tolkien", Price = 40, Genre = " Adventure, Drama, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode I - The Phantom Menace", Author = "George Lucas", Price = 40, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode II - Attack of the Clones", Author = "George Lucas", Price = 40, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode III - Revenge of the Sith", Author = "George Lucas", Price = 45, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode IV - A New Hope", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode V - The Empire Strikes Back", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode VI - Return of the Jedi", Author = "George Lucas", Price = 35, Genre = "Action, Adventure, Fantasy", BookCover = null },
            //    //new Book { Name = "Star Wars: Episode VII - The Force Awakens", Author = "George Lucas", Price = 50, Genre = "Action, Adventure, Fantasy" , BookCover = null}
            //};

            return _context.Books.ToList();
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
        }

        public void DeleteBook(int id)
        {
            Book book = _context.Books.Find(id);
            _context.Books.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    } 
}