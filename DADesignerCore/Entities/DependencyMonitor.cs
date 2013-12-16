using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class DependencyMonitor
    {

       DependencyMonitorElement element = new DependencyMonitorElement("DependencyMonitor");
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
       //
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

       public bool Enabled
       {
           get
           {
               return bool.Parse( Element.Attribute("Enabled").Value);
           }
           set
           {
               Element.Attribute("Enabled").Value = value.ToString().ToLower();
           }
       }
     //  
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
     //  
       public string ParentMonitorID
       {
           get
           {
               return Element.Attribute("ParentMonitorID").Value;
           }
           set
           {
               Element.Attribute("ParentMonitorID").Value = value;
           }
       }

       public bool Remotable
       {
           get
           {
               return bool.Parse(Element.Attribute("Remotable").Value);
           }
           set
           {
               Element.Attribute("Remotable").Value = value.ToString().ToLower();
           }
       }

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
      // 
       public string RelationshipType
       {
           get
           {
               return Element.Attribute("RelationshipType").Value;
           }
           set
           {
               Element.Attribute("RelationshipType").Value = value;
           }
       }
      // 
       public string MemberMonitor
       {
           get
           {
               return Element.Attribute("MemberMonitor").Value;
           }
           set
           {
               Element.Attribute("MemberMonitor").Value = value;
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
       public string Algorithm
       {
           get
           {
               return Element.Element("Algorithm").Value;
           }
           set
           {
               Element.Element("Algorithm").Value = value;
           }
       }

       public DependencyMonitorElement Element { get { return element; } }
    }
}
