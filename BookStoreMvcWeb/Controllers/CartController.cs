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
    public class CartController : Controller
    {
        private IProductRepository repository;
        public CartController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public RedirectToRouteResult AddToCart(Cart cart, int productID, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(e => e.ProductID == productID);
            if(product!=null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productID, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(x => x.ProductID == productID);

            if (product != null) cart.RemoveLine(product);
            return RedirectToAction("Index", new { returnUrl });
        }

        public ViewResult Checkout()
        {
            return View(new ShippingDetails());
        }

        [HttpPost]
        public ViewResult Checkout(ShippingDetails shiping)
        {
            return View("ShipingDetailsSummary", shiping);
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndextViewModel
                {
                    Cart = cart,
                    ReturnUrl = returnUrl
                });
        }
    }
}
