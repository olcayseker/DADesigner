using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class ClassType
    {
       ClassTypeElement element = new ClassTypeElement("ClassType");

        [XmlAttribute]
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
        [XmlAttribute]
        public string Accessibility
        {
            get
            {
                return Element.Attribute("Accessibility").Value;
            }
            set
            {
                Element.Attribute("Accessibility").Value = value;
            }
        }
        [XmlAttribute]
        public string Base
        {
            get
            {
                return Element.Attribute("Base").Value;
            }
            set
            {
                Element.Attribute("Base").Value = value;
            }
        }
        [XmlAttribute]
        public bool Abstract
        {
            get
            {
                return bool.Parse(Element.Attribute("Abstract").Value);
            }
            set
            {
                Element.Attribute("Abstract").Value = Convert.ToString(value).ToLower();
            }
        }
        [XmlAttribute]
        public bool Hosted
        {
            get
            {
                return bool.Parse(Element.Attribute("Hosted").Value);
            }
            set
            {
                Element.Attribute("Hosted").Value = Convert.ToString(value).ToLower();
            }
        }
        [XmlAttribute]
        public bool Singleton
        {
            get
            {
                return bool.Parse(Element.Attribute("Singleton").Value);
            }
            set
            {
                Element.Attribute("Singleton").Value = Convert.ToString(value).ToLower();
            }
        }
        public ClassTypeElement Element
        {
            get
            {
                return element;
            }
        }

        internal ClassType Parent { get; set; }
        internal string SimpleName { get; set; }
    }
}
