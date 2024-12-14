
using Models;
using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NullPriceStrategy : IPriceStrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult(new Discount("None", DateTime.Now));
        }
    }
}
