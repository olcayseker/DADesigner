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
            AddMandatoryObjects();
        }
        public ReferenceElement(XName name, object content)
            : base(name, content)
        {
            AddMandatoryObjects();
        }
        public ReferenceElement(XName name, params object[] content)
            : base(name, content)
        {
            AddMandatoryObjects();
        }
        public ReferenceElement(XElement other)
            : base(other)
        {
            AddMandatoryObjects();
        }
        public ReferenceElement(XStreamingElement other)
            : base(other)
        {
            AddMandatoryObjects();
        }

        void AddMandatoryObjects()
        {
            this.Name = "Reference";
            this.Add(new XAttribute("Alias", string.Empty));
            this.Add(new XElement("ID", string.Empty));
            this.Add(new XElement("Version", string.Empty));
            this.Add(new XElement("PublicKeyToken", string.Empty));
        }

        public string Alias
        {
            get
            {
                return this.Attribute("Alias").Value;
            }
            set
            {
                this.Attribute("Alias").Value = value;
            }
        }
        public string ID
        { 
        
            get
            {
               return this.Element("ID").Value;
            }
            set
            {
                this.Element("ID").Value = value;
            }
        }
        public string Version
        {
            get
            {
                return this.Element("Version").Value;
            }
            set
            {
                this.Element("Version").Value = value;
            }
        }

        public string PublicKeyToken
        {
            get
            {
                return this.Element("PublicKeyToken").Value;
            }
            set
            {
                this.Element("PublicKeyToken").Value = value;
            }
        }
    }
}
