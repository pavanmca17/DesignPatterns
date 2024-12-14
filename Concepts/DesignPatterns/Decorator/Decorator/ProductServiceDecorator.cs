


using Models;

namespace DesignPatterns
{
    class ProductServiceDecorator : IProductService
    {
        private IProductService _productService;
        private ILogger _logger;

        public ProductServiceDecorator(IProductService productService, ILogger logger)
        {
            _productService = productService;
            _logger = logger;
        }


        public Product GetProductById(int id)
        {
            var Product = _productService.GetProductById(id);
            // add extra Functionality here
            _logger.Log($"Logging using Decorator - Product ID {Product.Id} and Product Name {Product.Name}");
            return Product;


        }
    }
}
