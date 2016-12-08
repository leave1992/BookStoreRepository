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

        public BooksController()
        {
            _booksRepository = new BooksRepository();
        }
    
        [HttpGet]
        public ActionResult Home()
        {
            var books = _booksRepository.GetBooks();
            return View(books);
        }

        [HttpGet]
        public ActionResult View()
        {
            var books = _booksRepository.GetBooks();
            return View(books);
        }
    }
}