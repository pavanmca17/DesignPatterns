using DesignPatterns.Concepts;
using DesignPatterns.Strategy.Models;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy
{
    public class GoldMemberPriceStrategy : IPriceStrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new GoldMemeberDiscount(Constants.DiscountApprovedBy, DateTime.Now, 100));
        }
    }
}
