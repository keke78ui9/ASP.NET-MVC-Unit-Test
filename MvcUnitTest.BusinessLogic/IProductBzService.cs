using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcNinjectUnitTest.BusinessLogic
{
    public interface IProductBzService
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        int Unit { get; set; }
        bool ValidProduct { get; }


        decimal Total();

        decimal Tax(decimal extraPrice);

        
    }
}
