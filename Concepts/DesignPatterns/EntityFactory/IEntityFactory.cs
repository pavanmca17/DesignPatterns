using DesignPatterns.Adapter;
using DesignPatterns.Concepts;
using DesignPatterns.DesignPatterns.Strategy;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IEntityFactory
    {
        Task<IPriceStrategy> GeneratePriceStrategyEntity(PriceStrategyType priceStrategyType);

        Task<IGetData> GenerateFormatAdapter(DataFormatType dataFormatType);
    }
}
