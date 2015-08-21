using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreMvcWeb.Domain.Entities;
using BookStoreMvcWeb.Domain.Abstract;
using BookStoreMvcWeb.Domain.Concrete;
using System.Web.Security;

namespace BookStoreMvcWeb.Infrastructure.Concrete
{
    class FormsAuthProvider :IAuthProvider
    {
        public bool Authenticate(string username, string password)
        {
            bool result = FormsAuthentication.Authenticate(username, password);
            if (result) FormsAuthentication.SetAuthCookie(username, false);
            return result;
        }
    }
}
