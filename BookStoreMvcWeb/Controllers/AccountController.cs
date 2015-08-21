using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMvcWeb.Domain.Abstract;
using BookStoreMvcWeb.Domain.Concrete;
using BookStoreMvcWeb.Infrastructure.Concrete;
using BookStoreMvcWeb.Models;

namespace BookStoreMvcWeb.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider AuthProvider;

        public AccountController(IAuthProvider AuthProvider)
        {
            this.AuthProvider = AuthProvider;
        }


        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
                if (AuthProvider.Authenticate(model.UserName, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else{
                    ModelState.AddModelError("", "Nieprawidłowa nazwa użytkownika lub niepoprawne hasło");
                        return View();
                }
            else return View();
        }
    }
}
