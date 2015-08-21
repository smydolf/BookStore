using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMvcWeb.Models;
using BookStoreMvcWeb.Domain.Entities;
using BookStoreMvcWeb.Domain.Abstract;
using BookStoreMvcWeb.Domain.Concrete;

namespace BookStoreMvcWeb.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository repository {get; set;}
        public AdminController(IProductRepository repository)
        {
            this.repository=repository;
        }
       public ViewResult Index()
       {
           return View(repository.Products);
       }
       public ViewResult Edit(int ProductId)
       {
           Product product = repository.Products
               .FirstOrDefault(x => x.ProductID == ProductId);
           return View(product);
       }
        [HttpPost]
        public ActionResult Edit(Product product)
       {
           if (ModelState.IsValid)
           {
               repository.SaveProduct(product);
               return RedirectToAction("Index");
           }
           else return View(product);
       }
    }
}
