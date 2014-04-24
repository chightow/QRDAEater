using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;



namespace ConsoleApplication2
{
    class QRDAParser
    {

        private QRDA qrda = new QRDA();
       

        public string ReadXML( string xmlString )
        {
            using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            {

                qrda.Header = new QRDAHeader(reader);

            }
            return xmlString;
        }
    }
}
