using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class DisplayStringCollection : ICollection<DisplayString>
    {
        XElement displayStringElement;
           DisplayStringComparer comparer;

        public DisplayStringCollection(XElement parent)
        {
            displayStringElement = parent.Element("DisplayStrings");
            comparer = new DisplayStringComparer();
        }
        public void Add(DisplayString item)
        {
            displayStringElement.Add(new XElement("DisplayString", new XAttribute("ElementID", item.ElementID),
                new XElement("Name", item.Name),
                new XElement("Description", item.Description)));
        }

        public void Clear()
        {
            displayStringElement.RemoveNodes();
        }

        public bool Contains(DisplayString item)
        {
            return displayStringElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(DisplayString[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return displayStringElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(DisplayString item)
        {
            if (Contains(item))
            {
                displayStringElement.Elements("DisplayString").FirstOrDefault(z => comparer.Equals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<DisplayString> GetEnumerator()
        {
            return displayStringElement.Elements("DisplayString").Select(z => new DisplayString() {
                ElementID = z.Attribute("ElementID").Value,
                Name = z.Element("Name").Value,
                Description = z.Element("Description").Value,
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class DisplayStringComparer : IEqualityComparer<XElement>
    {
        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return x.Attribute("ElementID").Value.Equals(y.Attribute("ElementID").Value) &&
                x.Element("Name").Value.Equals(y.Element("Name").Value);
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Attribute("ElementID").Value.GetHashCode() + obj.Element("Name").Value.GetHashCode() * 4;
            }
        }
    }
}
