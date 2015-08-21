using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStoreMvcWeb.Domain.Entities;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace BookStoreMvcWeb.Binders
{
    public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
           Cart cart = (Cart)controllerContext.HttpContext.Session["sessionKey"];
          if (cart == null)
          {
              cart = new Cart();
              controllerContext.HttpContext.Session["sessionKey"] = cart;   
          }
            return cart;
        }
    }
}
