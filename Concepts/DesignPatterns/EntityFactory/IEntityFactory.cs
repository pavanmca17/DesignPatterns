using DesignPatterns.Concepts;
using DesignPatterns.DesignPatterns.Strategy;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns
{
    public interface IEntityFactory
    {
        Task<IPriceStrategy> GeneratePriceStrategyEntity(PriceStrategyType priceStrategyType);
    }
}
