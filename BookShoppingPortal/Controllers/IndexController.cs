using BookPortal.BL;
using BookShoppingPortal.Entitity;
using BookShoppingPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookShoppingPortal.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        BookingBL bookingBL;
        public IndexController() 
        {
            bookingBL = new BookingBL();   
        }
        public ActionResult Index()
        {

            IEnumerable<Book> book = bookingBL.GetBookDetails();
            return View(book);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Book book)
        {
            if(ModelState.IsValid)
            {
                bookingBL.AddBook(book);
                return RedirectToAction("index");
            }
            
                return View();
            }
        public ActionResult Edit(int id)
        {
            Book book = bookingBL.GetBookId(id);
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                bookingBL.EditBookDetails(book);
                return RedirectToAction("index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            bookingBL.DeleteBook(id);
            return RedirectToAction("index");
        }
        
    }
}