using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class MembershipRuleCollection : ICollection<MembershipRule>
    {
        XElement membershipRulesElement;
        MembershipRuleComparer comparer;
        public MembershipRuleCollection(XElement parent)
        {
            membershipRulesElement = parent.Element("MembershipRules");
            comparer = new MembershipRuleComparer();
        }
        public void Add(MembershipRule item)
        {
            membershipRulesElement.Add(new XElement("MembershipRule",
                new XElement("MonitoringClass", item.MonitoringClass),
                new XElement("RelationshipClass", item.RelationshipClass)));
        }

        public void Clear()
        {
            membershipRulesElement.RemoveNodes();
        }

        public bool Contains(MembershipRule item)
        {
            return membershipRulesElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(MembershipRule[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return membershipRulesElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false;  }
        }

        public bool Remove(MembershipRule item)
        {
            if(Contains(item))
            {
                membershipRulesElement.Elements("MembershipRule").FirstOrDefault(z => XNode.DeepEquals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<MembershipRule> GetEnumerator()
        {
            return membershipRulesElement.Elements("MembershipRule").Select(z => new MembershipRule()
            {
                MonitoringClass = z.Element("MonitoringClass").Value,
                RelationshipClass = z.Element("RelationshipClass").Value
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }

    class MembershipRuleComparer : IEqualityComparer<XElement>
    {
        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return x.Element("MonitoringClass").Value.Equals(y.Element("MonitoringClass").Value) &&
              x.Element("RelationshipClass").Value.Equals(y.Element("RelationshipClass").Value);
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Element("MonitoringClass").Value.GetHashCode() + obj.Element("RelationshipClass").Value.GetHashCode() * 4;
            }
        }
    }
}
