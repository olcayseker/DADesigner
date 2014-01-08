using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class ClassTypeElement:XElement
    {
        public ClassTypeElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public ClassTypeElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public ClassTypeElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public ClassTypeElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public ClassTypeElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "ClassType";
            this.Add(new XAttribute("ID", string.Empty),
                new XAttribute("Accessibility", "Public"),
                new XAttribute("Base", string.Empty),
                new XAttribute("Abstract", false),
                new XAttribute("Hosted", false),
                new XAttribute("Singleton", true));

        }
    }
}
