using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.DesignPatterns.Decorator.Model;

namespace DesignPatterns.DesignPatterns.Decorator.ServiceContracts
{
    interface IProductService
    {
        Product GetProductById(int id);
    }
}
