using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class DataSource
    {
       DataSourceElement element = new DataSourceElement("DataSource");
       public DataSource()
       {
           MembershipRules = new MembershipRuleCollection(element);
       }
      // 
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
       public string TypeID
       {
           get
           {
               return Element.Attribute("TypeID").Value;
           }
           set
           {
               Element.Attribute("TypeID").Value = value;
           }
       }

       public string RuleId
       {
           get
           {
               return Element.Element("RuleId").Value;
           }
           set
           {
               Element.Element("RuleId").Value = value;
           }
       }

       public string GroupInstanceId
       {
           get
           {
               return Element.Element("GroupInstanceId").Value;
           }
           set
           {
               Element.Element("GroupInstanceId").Value = value;
           }
       }

       public MembershipRuleCollection MembershipRules { get; set; }

       public DataSourceElement Element { get { return element; } }
    }
}
