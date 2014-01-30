using DADesignerCore.Entities;
using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class ManifestElement:XElement
    {
        public ManifestElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public ManifestElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public ManifestElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public ManifestElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public ManifestElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }    

        void Initialize()
        {
            //this.AddFirst(new XElement("Manifest",
            //    new XElement("Identity"),
            //    new XElement("Name"),
            //    new XElement("References")));           
            this.AddFirst(new XElement("Manifest",               
               new XElement("Name")
              )); 
        }

        //public void AddIdentity(IdentityElement Identity)
        //{
        //    this.Element("Manifest").Element("Identity").Remove();
        //    this.Element("Manifest").AddFirst(new XElement("Identity",
        //          new XElement("ID", Identity.ID),
        //          new XElement("Version", Identity.Version)));

        //}

    }
}
