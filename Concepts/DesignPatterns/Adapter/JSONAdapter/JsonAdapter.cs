using DesignPatterns.Adapter.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    class JsonAdapter : IGetData
    {
        public  async Task<string> GetData()
        {
            ExternalDataService dataservice = new ExternalDataService();
            List<ExternalData> sampleDtos = dataservice.GetData();
            return await Task.FromResult<string>(JsonConvert.SerializeObject(sampleDtos));            
        }

       
    }
}
