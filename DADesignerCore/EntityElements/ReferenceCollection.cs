using DADesignerCore.Entities;
using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.EntityElements
{
   public class ReferenceCollection:ICollection<Reference>
    {
        XElement referencesElement;
        ManifestElement _parent;
        ReferenceComparer comparer = new ReferenceComparer();
        public ReferenceCollection(ManifestElement parent)
        {
            _parent = parent;
            _parent.Element("Manifest").Add(new XElement("References"));
            referencesElement = _parent.Element("Manifest").Element("References");
        }
        public void Add(Reference item)
        {
            //referencesElement.Add(new XElement("Reference",
            //     new XAttribute("Alias", item.Alias),
            //     new XElement("ID", item.ID),
            //     new XElement("Version", item.Version),
            //     new XElement("PublicKeyToken", item.PublicKeyToken))); 
            referencesElement.Add(item.Element);
        }

        public void Clear()
        {
            referencesElement.RemoveNodes();
        }

        public bool Contains(Reference item)
        {
            //var xe = new XElement("Reference",
            //       new XAttribute("Alias", item.Alias),
            //       new XElement("ID", item.ID),
            //       new XElement("Version", item.Version),
            //       new XElement("PublicKeyToken", item.PublicKeyToken));

            return referencesElement.Elements().Contains(item.Element,comparer);
        }

        public void CopyTo(Reference[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return referencesElement.Elements().Count(); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Reference item)
        {
            if (Contains(item))
            {
                referencesElement.Elements("Reference").First(z => XNode.DeepEquals(item.Element,z)).Remove();
                
               
                return true;
            }
            return false;
        }

       public Reference this[int index]
        {
           get
            {
               if(this.Count >0 && index >-1)
               {
                  var referenceElement= referencesElement.Elements("Reference").ElementAt(index);
                  return new Reference(_parent,index)
                  {
                      ID = referenceElement.Element("ID").Value,
                      Version = referenceElement.Element("Version").Value,
                      PublicKeyToken = referenceElement.Element("PublicKeyToken").Value,
                      Alias = referenceElement.Attribute("Alias").Value
                  };
               }
                return null;
            }
        }
        public IEnumerator<Reference> GetEnumerator()
        {
            int count = -1;//index hep aynı!!!!
           return  referencesElement.Elements("Reference").Select(z => new Reference(_parent,count++) {ID=z.Element("ID").Value,
                                                                                             Version = z.Element("Version").Value,
                                                                                             PublicKeyToken = z.Element("PublicKeyToken").Value,
                                                                                             Alias = z.Attribute("Alias").Value

            }).GetEnumerator();
            
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class ReferenceComparer:IEqualityComparer<XElement>
   {

        public bool Equals(XElement x, XElement y)
       {
           if (x == null)
               return false;
           if (y == null)
               return false;

           return x.Element("ID").Value.Equals(y.Element("ID").Value) && x.Element("PublicKeyToken").Value.Equals(y.Element("PublicKeyToken").Value);
       }

        public int GetHashCode(XElement obj)
       {
           return obj.Element("ID").Value.GetHashCode();
       }
   }
}
