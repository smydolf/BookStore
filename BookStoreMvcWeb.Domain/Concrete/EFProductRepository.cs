using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreMvcWeb.Domain.Entities;
using BookStoreMvcWeb.Domain.Abstract;

namespace BookStoreMvcWeb.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IQueryable<Product> Products
        {
            get { return context.Product; }
        }
        public void SaveProduct(Product product)
        {
            if (product.ProductID == 0) context.Product.Add(product);
            else
            {
                Product dbEntry = context.Product.Find(product.ProductID);
                if (dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Author = product.Author;
                    dbEntry.Category = product.Category;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                }
            }
            context.SaveChanges();
        }
    }
}
