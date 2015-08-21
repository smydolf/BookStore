using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreMvcWeb.Domain.Entities;
using BookStoreMvcWeb.Models;

namespace BookStoreMvcWeb.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
