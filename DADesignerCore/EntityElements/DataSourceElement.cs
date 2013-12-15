using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DataSourceElement:XElement
    {
        public DataSourceElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public DataSourceElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public DataSourceElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public DataSourceElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public DataSourceElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "DataSource";
            this.Add(new XAttribute("ID",string.Empty),
                new XAttribute("TypeID",string.Empty),
                new XElement("RuleId",string.Empty),
                new XElement("GroupInstanceId",string.Empty),
                new XElement("MembershipRules",string.Empty));
        }
    }
}
