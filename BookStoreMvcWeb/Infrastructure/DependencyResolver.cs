using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Web.Mvc;
using BookStoreMvcWeb.Domain.Abstract;
using BookStoreMvcWeb.Domain.Concrete;
using BookStoreMvcWeb.Infrastructure.Concrete;

namespace BookStoreMvcWeb.Infrastructure
{
    public class DependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public DependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        public void AddBindings()
        {
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
            kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();
        }
    }
}
