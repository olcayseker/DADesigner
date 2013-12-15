using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class TypeDefinitionsElement:XElement
    {
        public TypeDefinitionsElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public TypeDefinitionsElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public TypeDefinitionsElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public TypeDefinitionsElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public TypeDefinitionsElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "TypeDefinitions";
            this.Add(new XElement("EntityTypes"));
        }

     
    }
}
