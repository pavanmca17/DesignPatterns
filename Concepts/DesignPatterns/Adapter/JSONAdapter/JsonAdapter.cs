using DesignPatterns.Models;
using Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class JsonAdapter : IGetData
    {
        public  async Task<string> GetData()
        {
            ExternalService externalService = new ExternalService();
            List<ExternalData> sampleDtos = externalService.GetData();
            return await Task.FromResult<string>(JsonConvert.SerializeObject(sampleDtos));            
        }

       
    }
}
