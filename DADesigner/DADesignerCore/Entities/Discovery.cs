using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class Discovery
    {
       DiscoveryElement element = new DiscoveryElement("Discovery");
       DiscoveryTypes _discoveryTypes;
       DataSource _dataSource;
       // [XmlAttribute]

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
      // [XmlAttribute]
       public bool Enabled
       {
           get
           {
               return bool.Parse(Element.Attribute("Enabled").Value);
           }
           set
           {
               Element.Attribute("Enabled").Value = Convert.ToString(value).ToLower();
           }
       }
     //  [XmlAttribute]
       public string Target
       {
           get
           {
               return Element.Attribute("Target").Value;
           }
           set
           {
               Element.Attribute("Target").Value = value;
           }
       }
       [XmlAttribute]
       public bool ConfirmDelivery
       {
           get
           {
               return bool.Parse(Element.Attribute("ConfirmDelivery").Value);
           }
           set
           {
               Element.Attribute("ConfirmDelivery").Value = Convert.ToString(value).ToLower();
           }
       }

       [XmlAttribute]
       public bool Remotable
       {
           get
           {
               return bool.Parse(Element.Attribute("Remotable").Value);
           }
           set
           {
               Element.Attribute("Remotable").Value = Convert.ToString(value).ToLower();
           }
       }
       [XmlAttribute]
       public string Priority
       {
           get
           {
               return Element.Attribute("Priority").Value;
           }
           set
           {
               Element.Attribute("Priority").Value = value;
           }
       }


       public string Category
       {
           get
           {
               return Element.Element("Category").Value;
           }
           set
           {
               Element.Element("Category").Value = value;
           }
       }

        public DiscoveryTypes DiscoveryTypes
       {
            get
           {
               return _discoveryTypes;
           }
            set
           {
               _discoveryTypes = value;
               Element.Element("DiscoveryTypes").Remove();
               Element.Add(_discoveryTypes.Element);
           }
       }

        public DataSource DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;
                Element.Element("DataSource").Remove();
                Element.Add(_dataSource.Element);
            }
        }

        public DiscoveryElement Element { get { return element; } }
    }
}
