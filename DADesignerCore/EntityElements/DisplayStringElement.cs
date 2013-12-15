using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DisplayStringElement:XElement
    {
        public DisplayStringElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public DisplayStringElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public DisplayStringElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public DisplayStringElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public DisplayStringElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "DisplayString";
            this.Add(new XAttribute("ElementID",string.Empty));
            this.Add(new XElement("Name"));
            this.Add(new XElement("Description"));

        }
    }
}
