using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreMvcWeb.Domain.Entities;

namespace BookStoreMvcWeb.Models 
{
    public class CartIndextViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
