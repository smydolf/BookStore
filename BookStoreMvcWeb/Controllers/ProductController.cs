using BookStoreMvcWeb.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStoreMvcWeb.Models;

namespace BookStoreMvcWeb.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult Index(string category, int page = 1)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = repository.Products
                .Where(p => category == null ? true : p.Category == category)
                .OrderBy(x => x.ProductID)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PageInfo = new PageInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ? repository.Products.Count() :
                    repository.Products.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(viewModel);
        }

    }
}
