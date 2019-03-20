using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1.Adapter
{
    class XmlAdapter : IGetDataAdapter
    {
        public string GetData()
        {
            String xml = string.Empty;
            ExternalDataService dataservice = new ExternalDataService();
            List<SampleDTO> sampleDtos = dataservice.GetData();            
            XmlDocument xmlDoc = new XmlDocument();
            XmlSerializer xmlSerializer = new XmlSerializer(sampleDtos.GetType());
            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, sampleDtos);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                xml =  xmlDoc.InnerXml;
            }
            return xml;

        }
    }
}
