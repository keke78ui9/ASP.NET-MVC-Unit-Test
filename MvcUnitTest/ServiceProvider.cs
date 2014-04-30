using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using MvcNinjectUnitTest.BusinessLogic;

namespace MvcNinjectUnitTest
{
    public class ServiceProvider : IServiceProvider
    {
        IKernel _kernel;
        public ServiceProvider()
        {
            _kernel = new StandardKernel(new MyModule());
        }

        public IProductBzService GetProductBzServicer()
        {
            return _kernel.Get<IProductBzService>();
        }
    }
}