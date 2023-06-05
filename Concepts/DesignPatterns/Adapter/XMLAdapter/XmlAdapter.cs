using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using DesignPatterns.Adapter.Model;

namespace DesignPatterns.Adapter
{
    class XmlAdapter : IGetData
    {
        public async Task<string> GetData()
        {
            string xml = string.Empty;
            ExternalDataService dataservice = new ExternalDataService();
            List<ExternalData> externalData = dataservice.GetData();            
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(externalData.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, externalData);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                xml =  xmlDoc.InnerXml;
            }

            return await Task.FromResult<string>(xml);           

        }
    }
}
