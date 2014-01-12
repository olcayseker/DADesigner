using DADesignerCore.Entities;
using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class ManifestElement:XElement
    {
        public ManifestElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public ManifestElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public ManifestElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public ManifestElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public ManifestElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "Manifest";
            this.Add(new XElement("Identity"));
            this.Add(new XElement("Name"));
            this.Add(new XElement("References"));
           
        }

        public void AddIdentity(IdentityElement Identity)
        {
            this.Element("Identity").Remove();
                       
            this.AddFirst(new XElement("Identity",
                  new XElement("ID", Identity.ID),
                  new XElement("Version", Identity.Version)));

        }

    }
}
