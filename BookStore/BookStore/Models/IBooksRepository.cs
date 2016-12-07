using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.Entities;

namespace BookStore.Models
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void DeleteBook(int id);
        void UpdateBook(Book book);
        void Save();
    }
}
