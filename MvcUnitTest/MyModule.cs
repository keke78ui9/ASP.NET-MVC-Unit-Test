using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using MvcNinjectUnitTest.BusinessLogic;

namespace MvcNinjectUnitTest
{
    public class MyModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductBzService>().To<ProductBzService>()
                .WithConstructorArgument("kernel", this.Kernel);
        }
    }
}
