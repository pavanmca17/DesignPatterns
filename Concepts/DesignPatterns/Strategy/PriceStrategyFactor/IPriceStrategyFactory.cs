using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IPriceStrategyFactory
    {
        Task<IPriceStrategy> GeneratePriceStrategy(PriceStrategyType priceStrategyType);

    }
}
