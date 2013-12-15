using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
    public class ClassTypeCollection : ICollection<ClassType>
    {
        XElement classTypeElement;
        ClassTypeComparer comparer;
        public ClassTypeCollection(XElement parent)
        {
            classTypeElement = parent.Element("ClassTypes");
            comparer = new ClassTypeComparer();
        }
        public void Add(ClassType item)
        {
            classTypeElement.Add(new XElement("ClassType",
                new XAttribute("ID",item.ID),
                new XAttribute("Base",item.Base),
                new XAttribute("Accessibility",item.Accessibility),
                new XAttribute("Abstract",item.Abstract),
                new XAttribute("Hosted",item.Hosted),
                new XAttribute("Singleton",item.Singleton)
                ));
        }

        public void Clear()
        {
            classTypeElement.RemoveNodes();
        }

        public bool Contains(ClassType item)
        {
            return classTypeElement.Elements().Contains(item.Element,comparer);
        }

        public void CopyTo(ClassType[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return classTypeElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public ClassType this[int index]
        {
            get
            {
                if(Count>0)
                {
                    var clazzElement = classTypeElement.Elements("ClassType").ElementAt(index);
                   ClassType clazzType = new ClassType() {
                       ID = clazzElement.Attribute("ID").Value,
                       Accessibility = clazzElement.Attribute("Accessibility").Value,
                       Base = clazzElement.Attribute("Base").Value,
                       Abstract =bool.Parse(clazzElement.Attribute("Abstract").Value),
                       Hosted = bool.Parse(clazzElement.Attribute("Hosted").Value),
                       Singleton = bool.Parse(clazzElement.Attribute("Singleton").Value)
                   };
                   return clazzType;
                }

                return null;
            }
        }
        public bool Remove(ClassType item)
        {
            if (Contains(item))
            {
                classTypeElement.Elements("ClassType").FirstOrDefault(z => comparer.Equals(z, item.Element)).Remove();            
                return true;
            }
            return false;
        }

        public IEnumerator<ClassType> GetEnumerator()
        {
            return classTypeElement.Elements("ClassType").Select(z => new ClassType() {
                ID = z.Attribute("ID").Value,
                Base = z.Attribute("Base").Value,
                Accessibility = z.Attribute("Accessibility").Value,
                Abstract =(bool) z.Attribute("Abstract"),
                Hosted = (bool)z.Attribute("Hosted"),
                Singleton = (bool)z.Attribute("Singleton"),
            }).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    class ClassTypeComparer : IEqualityComparer<XElement>
    {

        public bool Equals(XElement x, XElement y)
        {

            if (x == null)
                return false;
            if (y == null)
                return false;
            return x.Attribute("ID").Value.Equals(y.Attribute("ID").Value) &&
                x.Attribute("Base").Value.Equals(y.Attribute("Base").Value) &&
                x.Attribute("Accessibility").Value.Equals(y.Attribute("Accessibility").Value)&&
                x.Attribute("Abstract").Value.Equals(y.Attribute("Abstract").Value);
        }

        public int GetHashCode(XElement obj)
        {
            unchecked
            {
                return obj.Attribute("ID").Value.GetHashCode() + obj.Attribute("Base").Value.GetHashCode() * 4;
            }
            
        }
    }
      
}
