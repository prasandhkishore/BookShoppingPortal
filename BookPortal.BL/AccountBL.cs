using BookShoppingPortal.Entitity;
using BookShoppingPortal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPortal.BL
{
    public class AccountBL
    {
        AccountRepository accountRepository;
        public AccountBL()
        {
            accountRepository = new AccountRepository();
        }
        public void SignUp(Account account)
        {
            accountRepository.Signup(account);
        }
        public Account Login(Account account)
        {
            return accountRepository.Login(account);
        }
    }
}
