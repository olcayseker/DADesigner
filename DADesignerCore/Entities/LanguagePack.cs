using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
    public class LanguagePack
    {
        LanguagePackElement element = new LanguagePackElement("LanguagePack");

        public LanguagePack()
        {
            ID = "ENU";
            IsDefault = true;
            DisplayStrings = new DisplayStringCollection(element);
        }
       //  [XmlAttribute]
        public string ID
        {
            get
            {
                return Element.Attribute("ID").Value;
            }
            set
            {
                Element.Attribute("ID").Value = value;
            }
        }
      //   [XmlAttribute]
        public bool IsDefault
        {
            get
            {
                return bool.Parse(Element.Attribute("IsDefault").Value);
            }
            set
            {
                Element.Attribute("IsDefault").Value = value.ToString().ToLower();
            }
        }

        public DisplayStringCollection DisplayStrings { get;private set; }

         public KnowledgeArticles KnowledgeArticles { get; set; }

         public LanguagePackElement Element { get { return element; } }
        
    }
}
