using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DADesignerCore.Entities
{
   public class MembershipRule
    {
       MembershipRuleElement element = new MembershipRuleElement("MembershipRule");
       public string MonitoringClass
       {
           get
           {
               return element.Element("MonitoringClass").Value;
           }
           set
           {
               element.Element("MonitoringClass").Value = value;
           }
       }

       public string RelationshipClass
       {
           get
           {
               return element.Element("RelationshipClass").Value;
           }
           set
           {
               element.Element("RelationshipClass").Value = value;
           }
       }

       public MembershipRuleElement Element { get { return element; } }
    }
}
