using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMvcWeb.Domain.Abstract;

namespace BookStoreMvcWeb.Controllers
{
    public class NavigationController : Controller
    {
        private IProductRepository repository;

        public NavigationController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }

    }
}
