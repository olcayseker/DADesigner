using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DependencyMonitorCollection : ICollection<DependencyMonitor>
    {
        XElement dependencyMonitorElement;
        DependencyMonitorComparer comparer;

        public DependencyMonitorCollection(XElement parent)
        {
            dependencyMonitorElement = parent.Element("Monitors");
            comparer = new DependencyMonitorComparer();
        }
        public void Add(DependencyMonitor item)
        {
            dependencyMonitorElement.Add(new XElement("DependencyMonitor",
               new XAttribute("ID", item.ID),
                new XAttribute("Accessibility", item.Accessibility),
                new XAttribute("Enabled", item.Enabled),
                new XAttribute("Target", item.Target),
                new XAttribute("ParentMonitorID", item.ParentMonitorID),
                new XAttribute("Remotable", item.Remotable),
                 new XAttribute("Priority", item.Priority),
                new XAttribute("RelationshipType", item.RelationshipType),
                new XAttribute("MemberMonitor", item.MemberMonitor),
                new XElement("Category",item.Category),
                new XElement("Algorithm",item.Algorithm)));
        }

        public void Clear()
        {
            dependencyMonitorElement.RemoveNodes();
        }

        public bool Contains(DependencyMonitor item)
        {
            return dependencyMonitorElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(DependencyMonitor[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return dependencyMonitorElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(DependencyMonitor item)
        {
            if (Contains(item))
            {
                dependencyMonitorElement.Elements("DependencyMonitor").FirstOrDefault(z => comparer.Equals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<DependencyMonitor> GetEnumerator()
        {
            return dependencyMonitorElement.Elements("DependencyMonitor").Select(z => new DependencyMonitor()
            {
                ID = z.Attribute("ID").Value,
                Accessibility = z.Attribute("Accessibility").Value,
                Enabled = bool.Parse(z.Attribute("Enabled").Value),
                Target = z.Attribute("Target").Value,
                ParentMonitorID = z.Attribute("ParentMonitorID").Value,
                Remotable = bool.Parse(z.Attribute("Remotable").Value),
                Priority = z.Attribute("Priority").Value,
                RelationshipType = z.Attribute("RelationshipType").Value,
                MemberMonitor = z.Attribute("MemberMonitor").Value,
                Category = z.Element("Category").Value,
                Algorithm = z.Element("Algorithm").Value
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DependencyMonitorComparer : IEqualityComparer<XElement>
    {
        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return x.Attribute("ID").Value.Equals(y.Attribute("ID").Value) &&
                x.Attribute("Accessibility").Value.Equals(y.Attribute("Accessibility").Value) &&
               x.Attribute("Enabled").Value.Equals(y.Attribute("Enabled").Value) &&
              x.Attribute("Target").Value.Equals(y.Attribute("Target").Value) &&
              x.Attribute("Priority").Value.Equals(y.Attribute("Priority").Value) &&
              x.Attribute("Remotable").Value.Equals(y.Attribute("Remotable").Value) &&
              x.Attribute("Priority").Value.Equals(y.Attribute("Priority").Value) &&
              x.Element("Category").Value.Equals(y.Element("Category").Value)&&
               x.Element("Algorithm").Value.Equals(y.Element("Algorithm").Value);
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Attribute("ID").Value.GetHashCode() + obj.Attribute("Target").Value.GetHashCode() +
                    obj.Element("Category").Value.GetHashCode()* 4;
            }
        }
    }
}
