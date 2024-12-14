
using System;
using System.Threading.Tasks;
using Models;

namespace DesignPatterns
{
    public class GoldMemberPriceStrategy : IPriceStrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new GoldMemeberDiscount(Constants.DiscountApprovedBy, DateTime.Now, 100));
        }
    }
}
