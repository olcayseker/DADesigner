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
            this.Name = "Identity";
            this.Add(new XElement("ID", string.Empty));
            this.Add(new XElement("Version", string.Empty));
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
    }
}
