using DesignPatterns.DesignPatterns.Strategy.ServiceContract;
using DesignPatterns.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy.ServiceImplementation
{
    public class GoldMemberPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new GoldMemeberDiscount(Constants., DateTime.Now, 100));
        }
    }
}
