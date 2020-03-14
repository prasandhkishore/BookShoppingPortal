using BookShoppingPortal.Entitity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoppingPortal.Repository
{
    
        public class BookPortalDBContext : DbContext
        {
            public BookPortalDBContext() : base("BookPortalDBContext") { }


            public DbSet<Account> Accounts { get; set; }
            public DbSet<Book> Books { get; set; }
        }
    
}
