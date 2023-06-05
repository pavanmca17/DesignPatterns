using DesignPatterns.Strategy.Models;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy
{
    public class SilverMemberPriceStrategy : IPriceStrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new SilverMemeberDiscount("SilverMember", DateTime.Now, 50));
        }
    }
}
