using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class RelationshipTypeCollection : ICollection<RelationshipType>
    {
        XElement relationshipTypeElement;
        RelationshipTypeComparer comparer;
        public RelationshipTypeCollection(XElement parent)
        {
            relationshipTypeElement = parent.Element("RelationshipTypes");
            comparer = new RelationshipTypeComparer();
        }
        public void Add(RelationshipType item)
        {
           
            relationshipTypeElement.Add(new XElement("RelationshipType",
                new XAttribute("ID", item.ID),
                new XAttribute("Accessibility", item.Accessibility),
                new XAttribute("Base", item.Base),
                new XAttribute("Abstract", item.Abstract),
                new XElement("Source", item.Source),
                new XElement("Target", item.Target)
                ));
        }

        public void Clear()
        {
            relationshipTypeElement.RemoveNodes();
        }

        public bool Contains(RelationshipType item)
        {
            return relationshipTypeElement.Elements().Contains(item.Element, comparer);
        }

        public void CopyTo(RelationshipType[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return relationshipTypeElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(RelationshipType item)
        {
            if (Contains(item))
            {
                relationshipTypeElement.Elements("RelationshipType").FirstOrDefault(z => XNode.DeepEquals(z, item.Element)).Remove();
                return true;
            }
            return false;
        }

        public IEnumerator<RelationshipType> GetEnumerator()
        {
            return relationshipTypeElement.Elements("RelationshipType").Select(z => new RelationshipType() {
                ID = z.Attribute("ID").Value,
                Base = z.Attribute("Base").Value,
                Accessibility = z.Attribute("Accessibility").Value,
                Abstract = (bool)z.Attribute("Abstract"),
                Source = z.Element("Source").Value,
                Target = z.Element("Target").Value
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class RelationshipTypeComparer : IEqualityComparer<XElement>
    {

        public bool Equals(XElement x, XElement y)
        {
            if (x == null)
                return false;
            if (y == null)
                return false;

            return x.Attribute("ID").Value.Equals(y.Attribute("ID").Value) &&
              x.Attribute("Base").Value.Equals(y.Attribute("Base").Value) &&
              x.Attribute("Accessibility").Value.Equals(y.Attribute("Accessibility").Value) &&
              x.Attribute("Abstract").Value.Equals(y.Attribute("Abstract").Value) &&
              x.Element("Source").Value.Equals(y.Element("Source").Value) &&
              x.Element("Target").Value.Equals(y.Element("Target").Value);
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Attribute("ID").Value.GetHashCode() + obj.Element("Source").Value.GetHashCode() * 4;
            }
        }
    }
}
