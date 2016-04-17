using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Hiwayan
{
    public class HiwayanCongurationSectionHandler : IConfigurationSectionHandler
    {
        public object Create(
             object parent,
             object configContext,
             System.Xml.XmlNode section)
        {
            Type t = typeof(HiwayanConfiguration);
            XmlSerializer ser = new XmlSerializer(t);
            return ser.Deserialize(new XmlNodeReader(section));
        }
    }
}
