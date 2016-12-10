using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Migrations.Entities;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        private IBooksRepository _booksRepository;

        public AdminController()
        {
            _booksRepository = new BooksRepository();
        }

        [HttpGet]
        public ActionResult AllBooks()
        {
            var books = _booksRepository.GetBooks();
            return View(books);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepository.AddBook(book);
                _booksRepository.Save();
                return RedirectToAction("Home", "Books");
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult EditBook(string id = null)
        {
            int intId;
            int.TryParse(id, out intId);
            var book = _booksRepository.GetBookById(intId);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _booksRepository.UpdateBook(book);
                _booksRepository.Save();
                return RedirectToAction("Home", "Books");
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult DeleteBook(string id = null)
        {
            int intId;
            int.TryParse(id, out intId);
            var book = _booksRepository.GetBookById(intId);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("DeleteBook")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            int intId;
            int.TryParse(id, out intId);
            _booksRepository.DeleteBook(intId);
            _booksRepository.Save();

            return RedirectToAction("Home", "Books");
        }

    }
}