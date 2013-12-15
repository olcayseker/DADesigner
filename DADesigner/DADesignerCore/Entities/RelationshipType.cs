using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class RelationshipType
    {
       RelationshipTypeElement element = new RelationshipTypeElement("RelationshipType");

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

       public string Source
       {
           get
           {
               return Element.Element("Source").Value;
           }
           set
           {
               Element.Element("Source").Value = value;
           }
       }

       public string Target
       {
           get
           {
               return Element.Element("Target").Value;
           }
           set
           {
               Element.Element("Target").Value = value;
           }
       }

       public RelationshipTypeElement Element
       {
           get
           {
               return element;
           }
       }
    }
}
