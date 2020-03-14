using BookShoppingPortal.Entitity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShoppingPortal.Repository
{
    public class AccountRepository
    {
        public void Signup(Account account)
        {
            using (BookPortalDBContext accountContext = new BookPortalDBContext())
            {
                //accountContext.Accounts.ToList();
                accountContext.Accounts.Add(account);
                accountContext.SaveChanges();
            }
        }
        public Account Login(Account account)
        {

            using (BookPortalDBContext accountContext = new BookPortalDBContext())
            {
                Account result = accountContext.Accounts.Where(temp => temp.MailId == account.MailId && temp.MailId == account.MailId).FirstOrDefault();

                return result;
            }


        }
    }
}
