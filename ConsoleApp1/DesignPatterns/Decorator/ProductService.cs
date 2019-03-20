using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Decorator
{
    public class ProductService : IProductService
    {
        public Product GetProductById(int id)
        {
            return new Product() { Id = id ,Name = "Sample Product" };
        }
    }
}
