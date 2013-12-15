using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{

    public class DiscoveryTypesCollection : ICollection<DiscoveryTypes>
    {

        XElement discoveryTypesElement;
        DiscoveryTypesComparer comparer;

        public DiscoveryTypesCollection(XElement parent)
        {
            discoveryTypesElement = parent.Element("DiscoveryTypes");
            comparer = new DiscoveryTypesComparer();
        }
        public void Add(DiscoveryTypes item)
        {
            discoveryTypesElement.Add(new XElement("DiscoveryType"));
        }

        public void Clear()
        {
            discoveryTypesElement.RemoveNodes();
        }

        public bool Contains(DiscoveryTypes item)
        {
            return discoveryTypesElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(DiscoveryTypes[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return discoveryTypesElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; ; }
        }

        public bool Remove(DiscoveryTypes item)
        {
            if (Contains(item))
            {
                discoveryTypesElement.Elements("DiscoveryTypes").FirstOrDefault(z => XNode.DeepEquals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<DiscoveryTypes> GetEnumerator()
        {
            return discoveryTypesElement.Elements("DiscoveryTypes").Select(z => new DiscoveryTypes()
            {
               
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DiscoveryTypesComparer : IEqualityComparer<XElement>
    {
        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return true;
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.ToString().GetHashCode() * 4;
            }
        }
    }
}
