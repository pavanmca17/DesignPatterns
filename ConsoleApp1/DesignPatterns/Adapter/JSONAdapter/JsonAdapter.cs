using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    class JsonAdapter : IGetDataAdapter
    {

        public JsonAdapter()
        {

        }

        public String GetData()
        {
            ExternalDataService dataservice = new ExternalDataService();
            List<SampleDTO> sampleDtos = dataservice.GetData();
            string output = JsonConvert.SerializeObject(sampleDtos);
            return output;
        }

       
    }
}
