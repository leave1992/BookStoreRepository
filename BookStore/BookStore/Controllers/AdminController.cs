using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;
using BookStore.Models.Entities;

namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        private BooksStoreContext _context = new BooksStoreContext();

        [HttpGet]
        public ActionResult AllBooks()
        {
            return View(_context.Books.ToList());
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
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction("Index", "Books");
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult EditBook(string id = null)
        {
            int intId;
            int.TryParse(id, out intId);
            Book book = _context.Books.Find(intId);
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
                _context.Entry(book).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index", "Books");
            }
            return View(book);
        }

        [HttpGet]
        public ActionResult DeleteBook(string id = null)
        {
            int intId;
            int.TryParse(id, out intId);
            Book book = _context.Books.Find(intId);
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
            Book book = _context.Books.Find(intId);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return RedirectToAction("Index", "Books");
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }

    }
}