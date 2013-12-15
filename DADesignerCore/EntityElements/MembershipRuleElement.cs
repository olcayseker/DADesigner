using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class MembershipRuleElement:XElement
    {
        public MembershipRuleElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public MembershipRuleElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public MembershipRuleElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public MembershipRuleElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public MembershipRuleElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "MembershipRule";
            this.Add(new XElement("MonitoringClass",string.Empty));
            this.Add(new XElement("RelationshipClass", string.Empty));
        }
    }
}
