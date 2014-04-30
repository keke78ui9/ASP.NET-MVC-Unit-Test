using System;
using MvcNinjectUnitTest.BusinessLogic;
namespace MvcNinjectUnitTest
{
    public interface IServiceProvider
    {
        IProductBzService GetProductBzServicer();
    }
}
