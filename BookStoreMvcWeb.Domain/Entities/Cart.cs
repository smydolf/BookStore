using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreMvcWeb.Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public IEnumerable<CartLine> Lines { get { return lineCollection; } }

        public void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .FirstOrDefault(p => p.Product.ProductID == product.ProductID);
            if (line == null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.ProductID == product.ProductID);
        }
        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(p => p.Product.Price * p.Quantity);
        }
        public void Clear()
        {
            lineCollection.Clear();
        }

    }
}


