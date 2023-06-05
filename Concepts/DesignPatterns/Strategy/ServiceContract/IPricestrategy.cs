using DesignPatterns.Strategy.Models;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy.ServiceContract
{
    public interface IPricestrategy
    {
        Task<Discount> GetDiscount();
    }
}
