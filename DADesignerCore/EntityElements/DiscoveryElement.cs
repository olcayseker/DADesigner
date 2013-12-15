using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DiscoveryElement:XElement
    {
        public DiscoveryElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public DiscoveryElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public DiscoveryElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public DiscoveryElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public DiscoveryElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "Discovery";
            this.Add(new XAttribute("ID","false"),
                new XAttribute("Enabled","false"),
                new XAttribute("Target","false"),
                new XAttribute("ConfirmDelivery","false"),
                new XAttribute("Remotable","false"),
                new XAttribute("Priority","false"));
            this.Add(new XElement("Category", string.Empty));
            this.Add(new XElement("DiscoveryTypes", string.Empty));
            this.Add(new XElement("DataSource", string.Empty));
        }
    }
}
