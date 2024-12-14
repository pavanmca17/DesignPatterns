using Models;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class ExternalService
    {
        public List<ExternalData> GetData()
        {
            return new List<ExternalData>()
            {
                new ExternalData() { ID =1},
                new ExternalData() { ID =2},
                new ExternalData(){ ID =3},
                new ExternalData(){ ID =4},
                new ExternalData(){ ID =5}
            };
        }
    }
}
