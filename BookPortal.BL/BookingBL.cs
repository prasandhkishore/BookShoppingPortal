using BookShoppingPortal.Entitity;
using BookShoppingPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPortal.BL
{
    public class BookingBL
    {
        BookRepository bookRepository;
        public BookingBL()
        {
            bookRepository = new BookRepository();
        }
        
        public void AddBook(Book book)
        {
            bookRepository.AddBook(book);
        }
        public IEnumerable<Book> GetBookDetails()
        {
            IEnumerable<Book> books = bookRepository.GetBookDetails();
            return books;
        }
        public void DeleteBook(int bookId)
        {
            bookRepository.DeleteBook(bookId);
        }
        public Book GetBookId(int bookId)
        {
            Book books = bookRepository.GetBookId(bookId);
            return books;
        }
        public void EditBookDetails(Book book)
        {
            bookRepository.EditBook(book);
        }
    }
}
