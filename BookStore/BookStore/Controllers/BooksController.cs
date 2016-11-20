using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        private IBooksRepository _booksRepository;

        // GET: Books
        public ActionResult Index()
        {
            var repository = new BooksRepository();
            _booksRepository = repository;
            var books = _booksRepository.GetBooks();
            foreach (var book in books)
            {
                if (book.BookCover == null)
                {
                    book.BookCover = new Image
                    {
                        Path = "http://craigmod.com/images/journal/coccyx/aba-04.png"
                    };
                }
            }

            return View(books);
        }
    }
}