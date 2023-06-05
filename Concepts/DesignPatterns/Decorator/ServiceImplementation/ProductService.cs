using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DesignPatterns.Decorator.Model;
using DesignPatterns.DesignPatterns.Decorator.ServiceContracts;

namespace DesignPatterns.DesignPatterns.Decorator.ServiceImplementation
{
    public class ProductService : IProductService
    {
        public Product GetProductById(int id)
        {
            return new Product() { Id = id, Name = "Sample Product" };
        }
    }
}
