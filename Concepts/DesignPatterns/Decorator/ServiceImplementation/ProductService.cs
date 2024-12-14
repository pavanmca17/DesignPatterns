

using Models;

namespace DesignPatterns
{
    public class ProductService : IProductService
    {
        public Product GetProductById(int id)
        {
            return new Product() { Id = id, Name = "Sample Product" };
        }
    }
}
