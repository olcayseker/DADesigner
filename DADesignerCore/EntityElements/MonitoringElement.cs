using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class MonitoringElement:XElement
    {
        public MonitoringElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public MonitoringElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public MonitoringElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public MonitoringElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public MonitoringElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "Monitoring";
            this.Add(new XElement("Discoveries"));
            this.Add(new XElement("Monitors"));
        }
    }
}
