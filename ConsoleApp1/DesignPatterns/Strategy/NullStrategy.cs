using ConsoleApp1.Strategy;
using ConsoleApp1.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NullPriceStrategy : IPricestrategy
    {
        public async Task<Discount> GetDiscount()
        {
            return await Task.FromResult<Discount>(new Discount("None",DateTime.Now));
        }
    }
}
