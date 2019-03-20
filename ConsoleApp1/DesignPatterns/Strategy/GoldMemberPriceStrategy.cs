using ConsoleApp1.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    public class GoldMemberPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult<GoldMemeberDiscount>(new GoldMemeberDiscount("Pavan", DateTime.Now, 100));
        }
    }
}
