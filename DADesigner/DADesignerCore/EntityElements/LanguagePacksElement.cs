using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class LanguagePacksElement:XElement
    {
        public LanguagePacksElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public LanguagePacksElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public LanguagePacksElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public LanguagePacksElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public LanguagePacksElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "LanguagePacks";
            this.Add(new XElement("LanguagePack"));
        }
    }
}
