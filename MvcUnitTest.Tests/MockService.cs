using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcNinjectUnitTest.BusinessLogic;
using Moq;
using MvcNinjectUnitTest.Data;

namespace MvcNinjectUnitTest.Tests
{
    public class MockService
    {
        public static IProductBzService GetProductService()
        {
            Mock<IProductBzService> mock = new Mock<IProductBzService>();
            mock.SetupGet(x => x.Id).Returns(1);
            mock.SetupGet(x => x.Name).Returns("test name");
            mock.SetupGet(x => x.Price).Returns(11.11m);
            mock.SetupGet(x => x.Unit).Returns(2);
            mock.Setup(x => x.Total()).Returns(999.999m);

            return mock.Object;
        }

        public static IProductDataService GetProductDataService()
        {
            Mock<IProductDataService> mock = new Mock<IProductDataService>();
            mock.Setup(x => x.Total()).Returns(8888.88m);
            mock.SetupGet(x => x.Tax(1)).Returns(123.123m);

            return mock.Object;
        }
    }
}
