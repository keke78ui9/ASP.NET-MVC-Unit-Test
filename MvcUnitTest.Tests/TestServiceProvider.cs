using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using MvcNinjectUnitTest.BusinessLogic;

namespace MvcNinjectUnitTest.Tests
{
    public class TestServiceProvider : IServiceProvider
    {
        IKernel kernel;
        public TestServiceProvider()
        {
            kernel = new StandardKernel(new TestModule());
        }

		  public IProductBzService GetProductBzServicer()
		  {
			  return MockService.GetProductService();
		  }
	 }
}
