using System.Threading.Tasks;
using Models;

namespace DesignPatterns
{
    public interface IPriceStrategy
    {
        public Task<Discount> GetDiscount();
    }
}
