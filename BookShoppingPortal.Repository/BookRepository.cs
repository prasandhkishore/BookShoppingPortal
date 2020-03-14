using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShoppingPortal.Entitity;

namespace BookShoppingPortal.Repository
{
    public class BookRepository
    {
       public static List<Book> books = new List<Book>();
        static BookRepository()
        {
            books.Add(new Book { BookId = 1, BookName = "Happy Us!!!", BookAuthor = "Dinesh", Category = "Action", Price = 350 });
            books.Add(new Book { BookId = 2, BookName = "Don't Breath", BookAuthor = "Harish", Category = "Thriller", Price = 250 });
            books.Add(new Book { BookId = 3, BookName = "Go With The Flow", BookAuthor = "Sathiya", Category = "Love", Price = 350 });
            books.Add(new Book { BookId = 4, BookName = "The End Begins", BookAuthor = "Manoj", Category = "Comedy", Price = 250 });
        }
        public Book GetBookId(int bookId)
        {
            using (BookPortalDBContext bookPortalDBContext = new BookPortalDBContext())
            {
                return bookPortalDBContext.Books.Find(bookId);
            }
        }
        public IEnumerable<Book> GetBookDetails()
        {
            using(BookPortalDBContext bookPortalDBContext = new BookPortalDBContext())
            {
                List<Book> books = bookPortalDBContext.Books.ToList();
                return books;
            }
        }
        public void AddBook(Book book)
        {
            using (BookPortalDBContext bookPortalDBContext = new BookPortalDBContext())
            {
                bookPortalDBContext.Books.ToList();
                bookPortalDBContext.Books.Add(book);
                bookPortalDBContext.SaveChanges();
            }
            
        }
        public void DeleteBook(int bookId)
        {
            using (BookPortalDBContext bookPortalDBContext = new BookPortalDBContext())
            {
                Book book = bookPortalDBContext.Books.Find(bookId);
                if(book != null)
                {
                    bookPortalDBContext.Books.Remove(book);
                }
                bookPortalDBContext.SaveChanges();
            }
        }
        public void EditBook(Book book)
        {
            Book updateBook = GetBookId(book.BookId);
            updateBook.BookName = book.BookName;
            updateBook.BookAuthor = book.BookAuthor;
            updateBook.Category = book.Category;
            updateBook.Price = book.Price;
        }
       



    }
}
