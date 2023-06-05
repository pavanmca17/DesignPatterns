using DesignPatterns.Adapter.Interface;
using DesignPatterns.Adapter.StubExternalDataSource;
using DesignPatterns.DesignPatterns.Adapter.StubExternalDataSource;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Adapter
{
    class XmlAdapter : IGetData
    {
        public async Task<string> GetData()
        {
            string xml = string.Empty;
            ExternalDataService dataservice = new ExternalDataService();
            List<ExternalData> sampleDtos = dataservice.GetData();            
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(sampleDtos.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, sampleDtos);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                xml =  xmlDoc.InnerXml;
            }

            return await Task.FromResult<string>(xml);           

        }
    }
}
