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
            var books =  _booksRepository.GetBooks();

            return View(books);
        }
    }
}