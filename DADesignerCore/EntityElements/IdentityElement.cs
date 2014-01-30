using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class IdentityElement:XElement
    {
        public IdentityElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public IdentityElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public IdentityElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public IdentityElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public IdentityElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {            
            this.Element("Manifest").Add(new XElement("Identity",
                new XElement("ID", string.Empty),
                new XElement("Version", string.Empty)));
        }

      
    }
}
