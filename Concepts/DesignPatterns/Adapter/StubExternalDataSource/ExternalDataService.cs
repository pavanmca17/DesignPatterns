
using DesignPatterns.Adapter.Model;
using System.Collections.Generic;


namespace DesignPatterns.Adapter
{
    public class ExternalDataService
    {
        public List<ExternalData> GetData()
        {
            return new List<ExternalData>()
            {
                new ExternalData() {ID =1},
                new ExternalData() { ID =2}
            };
        }
    }
}
