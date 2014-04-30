using System;
namespace MvcNinjectUnitTest.Data
{
    public interface IProductDataService
    {
        decimal Tax(decimal extraPrice);
        decimal Total();
    }
}
