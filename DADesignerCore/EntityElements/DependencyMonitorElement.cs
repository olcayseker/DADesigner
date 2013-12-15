using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DependencyMonitorElement : XElement
    {
        public DependencyMonitorElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public DependencyMonitorElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public DependencyMonitorElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public DependencyMonitorElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public DependencyMonitorElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "DependencyMonitor";
            this.Add(new XAttribute("ID", string.Empty),
                new XAttribute("Accessibility", string.Empty),
                new XAttribute("Enabled", "false"),
                new XAttribute("Target", string.Empty),
                new XAttribute("ParentMonitorID", string.Empty),
                new XAttribute("Remotable", "false"),
                 new XAttribute("Priority", string.Empty),
                new XAttribute("RelationshipType", string.Empty),
                new XAttribute("MemberMonitor", string.Empty));
            this.Add(new XElement("Category"));
            this.Add(new XElement("Algorithm"));

        }
    }
}
