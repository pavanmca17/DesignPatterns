using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    public class ExternalDataService
    {
        public List<SampleDTO> GetData()
        {
            return new List<SampleDTO>()
            {
                new SampleDTO() {ID =1},
                new SampleDTO() { ID =2}
            };
        }
    }
}
