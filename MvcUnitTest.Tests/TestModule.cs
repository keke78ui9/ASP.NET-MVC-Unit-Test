using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject.Modules;
using MvcNinjectUnitTest.BusinessLogic;
using MvcNinjectUnitTest.Data;

namespace MvcNinjectUnitTest.Tests
{
    public class TestModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IProductBzService>().ToMethod(x => MockService.GetProductService());

            Bind<IProductBzService>().To<MyTestProductBzService>()
               .WithConstructorArgument("kernel", this.Kernel);
            Bind<IProductDataService>().ToMethod(x => MockService.GetProductDataService());
        }
    }
}
