using DesignPatterns.Strategy.Models;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy
{
    public class NullPriceStrategy : IPriceStrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new Discount("None", DateTime.Now));
        }
    }
}
