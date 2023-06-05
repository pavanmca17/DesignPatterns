using DesignPatterns.DesignPatterns.Strategy.ServiceContract;
using DesignPatterns.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy.ServiceImplementation
{
    public class NullPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new Discount("None", DateTime.Now));
        }
    }
}
