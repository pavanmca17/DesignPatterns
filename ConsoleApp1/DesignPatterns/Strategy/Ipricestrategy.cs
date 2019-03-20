using ConsoleApp1.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    public interface IPricestrategy
    {
        Task<Discount> GetDiscount();
    }
}
