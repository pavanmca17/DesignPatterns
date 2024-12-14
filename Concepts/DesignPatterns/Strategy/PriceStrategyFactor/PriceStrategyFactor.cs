
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Strategy.PriceStrategyFactor
{
    public class PriceStrategyFactor : IPriceStrategyFactory
    {
        public async Task<IPriceStrategy> GeneratePriceStrategy(PriceStrategyType priceStrategyType)
        {
            IPriceStrategy _priceStrategy = null;

            if (priceStrategyType == PriceStrategyType.Null)
            {
                _priceStrategy = new NullPriceStrategy();
            }
            else if (priceStrategyType == PriceStrategyType.SilverMember)
            {
                _priceStrategy = new SilverMemberPriceStrategy();
            }
            else if (priceStrategyType == PriceStrategyType.GoldMember)
            {
                _priceStrategy = new GoldMemberPriceStrategy();
            }

            return await Task.FromResult(_priceStrategy);
        }


    }
}
