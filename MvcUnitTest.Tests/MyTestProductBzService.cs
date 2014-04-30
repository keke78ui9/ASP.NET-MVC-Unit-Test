using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcNinjectUnitTest.BusinessLogic;
using Ninject;
using MvcNinjectUnitTest.Data;

namespace MvcNinjectUnitTest.Tests
{
    public class MyTestProductBzService : IProductBzService
    {
         IKernel _kernel;
        IProductDataService productService;
        public MyTestProductBzService(IKernel kernel)
        {
            _kernel = kernel;
            
            productService = kernel.TryGet<IProductDataService>() ?? new ProductDataService();
           
        }


        #region IProductBzService Members

        public int Id
        {
            get
            {
					return 111;
            }
            set
            {
					Id = value;
            }
        }

        public string Name
        {
            get
            {
					return "from unit test!!";
            }
            set
            {
					Name = value;
            }
        }

        public decimal Price
        {
            get
            {
					return 134.23m;
            }
            set
            {
					Price = value;
            }
        }

        public int Unit
        {
            get
            {
					return 99;
            }
            set
            {
					Unit = value;
            }
        }

        public bool ValidProduct
        {
			  get { return true; }
        }

        public decimal Total()
        {
			  //return Unit * Price;
			  return productService.Total();
        }

        public decimal Tax(decimal extraPrice)
        {
			  return productService.Tax(1);

			  //return Unit * (Price + extraPrice);
        }

        #endregion
    }
}
