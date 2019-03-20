using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProductServiceDecorator : IProductService
    {
        private IProductService _productService;
        private ILogger _logger;

        public ProductServiceDecorator(IProductService productService,ILogger logger)
        {
            _productService = productService;
            _logger = logger;
        }


        public Product GetProductById(int id)
        {
           var Product = _productService.GetProductById(id);
            _logger.Log($"Logging using Decorator - Product ID {Product.Id} and Product Name {Product.Name}");
            return Product;


        }
    }
}
