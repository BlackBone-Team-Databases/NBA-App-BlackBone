using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NBABlackBone.Parsers
{
    class XmlParse
    {
        public void Parse(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            StringWriter sw = new StringWriter();
            XmlTextWriter tx = new XmlTextWriter(sw);
            doc.WriteTo(tx);
            sw.ToString();
        }
    }
}
