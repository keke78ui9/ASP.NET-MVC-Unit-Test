using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using MvcNinjectUnitTest.Data;

namespace MvcNinjectUnitTest.BusinessLogic
{
    public class ProductBzService : IProductBzService
    {
        IKernel _kernel;
        IProductDataService productService;
        public ProductBzService(IKernel kernel)
        {
            _kernel = kernel;
            
            productService = kernel.TryGet<IProductDataService>() ?? new ProductDataService();
           
        }
       
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Unit
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool ValidProduct
        {
            get { throw new NotImplementedException(); }
        }

        public decimal Total()
        {
            return productService.Total();
        }

        public decimal Tax(decimal extraPrice)
        {
            throw new NotImplementedException();
        }

    }
}
