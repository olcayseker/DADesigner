using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DiscoveryTypesElement:XElement
    {
        public DiscoveryTypesElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public DiscoveryTypesElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public DiscoveryTypesElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public DiscoveryTypesElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public DiscoveryTypesElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "DiscoveryTypes";
            
        }
    }
}
