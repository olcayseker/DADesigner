using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class EntityTypesElement:XElement
    {
        public EntityTypesElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public EntityTypesElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public EntityTypesElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public EntityTypesElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public EntityTypesElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "EntityTypes";
            this.Add(new XElement("ClassTypes"));
            this.Add(new XElement("RelationshipTypes"));
        }
    }
}
