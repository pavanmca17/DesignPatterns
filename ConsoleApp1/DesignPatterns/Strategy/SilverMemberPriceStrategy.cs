using ConsoleApp1.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    public class SilverMemberPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult<SilverMemeberDiscount>(new SilverMemeberDiscount("Pavan", DateTime.Now, 50));
        }
    }
}
