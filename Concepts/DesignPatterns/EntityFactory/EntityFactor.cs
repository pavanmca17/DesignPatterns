using DesignPatterns.Adapter;
using DesignPatterns.Concepts;
using DesignPatterns.DesignPatterns.Strategy;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.EntityFactory
{
    public class EntityFactor : IEntityFactory
    {  
        public async Task<IPriceStrategy> GeneratePriceStrategyEntity(PriceStrategyType priceStrategyType)
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
            else if(priceStrategyType == PriceStrategyType.GoldMember)
            {
                _priceStrategy = new GoldMemberPriceStrategy();
            }

            return await Task.FromResult(_priceStrategy);
        }

        public async Task<IGetData> GenerateFormatAdapter(DataFormatType dataFormatType)
        {
            IGetData _getData = null;

            if(dataFormatType == DataFormatType.JSON)
            {
                _getData = new JsonAdapter();
            }
            else if(dataFormatType == DataFormatType.XML)
            {
                _getData = new XmlAdapter();
            }

            return await Task.FromResult(_getData);
        }
    }
}
