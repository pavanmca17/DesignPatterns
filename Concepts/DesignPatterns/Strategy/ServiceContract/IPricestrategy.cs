using DesignPatterns.Strategy.Models;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy
{
    public interface IPriceStrategy
    {
        public Task<Discount> GetDiscount();
    }
}
