using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class ReferenceElement:XElement
    {
        public ReferenceElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public ReferenceElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public ReferenceElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public ReferenceElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public ReferenceElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "Reference";
            this.Add(new XAttribute("Alias", string.Empty));
            this.Add(new XElement("ID", string.Empty));
            this.Add(new XElement("Version", string.Empty));
            this.Add(new XElement("PublicKeyToken", string.Empty));

           //this.Element("Manifest").Element("References").Add(
           //     new XElement("Reference",
           //     new XAttribute("Alias", string.Empty),
           //     new XElement("ID", string.Empty),
           //     new XElement("Version", string.Empty),
           //     new XElement("PublicKeyToken", string.Empty)
           //     ));
        }

     
        
    }
}
