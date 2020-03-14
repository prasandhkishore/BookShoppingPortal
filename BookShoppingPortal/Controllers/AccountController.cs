using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookPortal.BL;
using BookShoppingPortal.Entitity;
using BookShoppingPortal.Models;

namespace BookShoppingPortal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                Account account = new Account();
                account.MailId = loginViewModel.EmailId;
                account.Password = loginViewModel.Password;
                
            }
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                Account account = new Account();
              
                account.Name = signUpViewModel.Name;
                account.MailId = signUpViewModel.EmailId;
                account.Password = signUpViewModel.Password;
                account.Gender = signUpViewModel.Gender;
                account.Age = signUpViewModel.Age;
                AccountBL accountBL = new AccountBL();
                accountBL.SignUp(account);

            return View("Login");
            }
            return View();
        }
    }
}