using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DiscoveryCollection : ICollection<Discovery>
    {
        XElement discoveryElement;
        DiscoveryComparer comparer;

        public DiscoveryCollection(XElement parent)
        {
            discoveryElement = parent.Element("Discoveries");
            comparer = new DiscoveryComparer();
        }
        public void Add(Discovery item)
        {
            discoveryElement.Add(new XElement("Discovery",
                new XAttribute("ID",item.ID),
                new XAttribute("Enabled",item.Enabled),
                new XAttribute("Target",item.Target),
                new XAttribute("ConfirmDelivery",item.ConfirmDelivery),
                new XAttribute("Remotable",item.Remotable),
                new XAttribute("Priority",item.Priority),
                new XElement("Category",item.Category),
                new XElement(item.DiscoveryTypes.Element),
                new XElement( item.DataSource.Element)));
        }

        public void Clear()
        {
            discoveryElement.RemoveNodes();
        }

        public bool Contains(Discovery item)
        {
            return discoveryElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(Discovery[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return discoveryElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Discovery item)
        {
            if (Contains(item))
            {
                discoveryElement.Elements("Discovery").FirstOrDefault(z => comparer.Equals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<Discovery> GetEnumerator()
        {
            return discoveryElement.Elements("Discovery").Select(z => new Discovery()
            {
                ID = z.Attribute("ID").Value,
                Enabled = bool.Parse(z.Attribute("Enabled").Value),
                Target = z.Attribute("Target").Value,
                ConfirmDelivery = bool.Parse(z.Attribute("ConfirmDelivery").Value),
                Remotable = bool.Parse(z.Attribute("Remotable").Value),
                Priority = z.Attribute("Priority").Value,
                Category = z.Element("Category").Value,
                DiscoveryTypes = new DiscoveryTypes(),
                DataSource = new DataSource() { ID = z.Element("DataSource").Attribute("ID").Value,
                                                TypeID = z.Element("DataSource").Attribute("TypeID").Value,
                                                RuleId = z.Element("DataSource").Element("RuleId").Value,
                                                GroupInstanceId = z.Element("DataSource").Element("GroupInstanceId").Value,
                                                MembershipRules = new MembershipRuleCollection(z.Element("DataSource"))
                }
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DiscoveryComparer : IEqualityComparer<XElement>
    {
        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return x.Attribute("ID").Value.Equals(y.Attribute("ID").Value) &&
               x.Attribute("Enabled").Value.Equals(y.Attribute("Enabled").Value) &&
              x.Attribute("Target").Value.Equals(y.Attribute("Target").Value) &&
              x.Attribute("Priority").Value.Equals(y.Attribute("Priority").Value) &&
              x.Attribute("Remotable").Value.Equals(y.Attribute("Remotable").Value) &&
              x.Attribute("Priority").Value.Equals(y.Attribute("Priority").Value) &&
              x.Element("Category").Value.Equals(y.Element("Category").Value); 
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Attribute("ID").Value.GetHashCode() + obj.Attribute("Target").Value.GetHashCode() * 4;
            }
        }
    }
}
