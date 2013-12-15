using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class RelationshipTypeElement:XElement
    {
        public RelationshipTypeElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public RelationshipTypeElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public RelationshipTypeElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public RelationshipTypeElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public RelationshipTypeElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "RelationshipType";
            this.Add(new XAttribute("ID", string.Empty),
                new XAttribute("Accessibility", string.Empty),
                new XAttribute("Base", string.Empty),
                new XAttribute("Abstract", false),
                new XElement("Source",string.Empty),
                new XElement("Target", string.Empty)
                );
        }
    }
}
