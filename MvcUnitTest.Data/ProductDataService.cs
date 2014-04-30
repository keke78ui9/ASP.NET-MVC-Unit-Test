using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcNinjectUnitTest.Data
{
    public class ProductDataService : IProductDataService
    {
        public decimal Total()
        {
            return 99.99m;
        }

        public decimal Tax(decimal extraPrice)
        {
            return 123.99m + extraPrice;
        }
    }
}
