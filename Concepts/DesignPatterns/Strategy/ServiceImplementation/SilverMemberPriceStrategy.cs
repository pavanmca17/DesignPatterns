using DesignPatterns.DesignPatterns.Strategy.ServiceContract;
using DesignPatterns.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy.ServiceImplementation
{
    public class SilverMemberPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new SilverMemeberDiscount("Pavan", DateTime.Now, 50));
        }
    }
}
