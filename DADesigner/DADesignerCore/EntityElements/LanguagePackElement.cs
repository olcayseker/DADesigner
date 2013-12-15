using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class LanguagePackElement:XElement
    {
        public LanguagePackElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public LanguagePackElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public LanguagePackElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public LanguagePackElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public LanguagePackElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }

        void Initialize()
        {
            this.Name = "LanguagePack";
            this.Add(new XAttribute("ID", "ENU"));
            this.Add(new XAttribute("IsDefault", "true"));
            this.Add(new XElement("DisplayStrings"));
            this.Add(new XElement("KnowledgeArticles"));
              
        }
    }
}
