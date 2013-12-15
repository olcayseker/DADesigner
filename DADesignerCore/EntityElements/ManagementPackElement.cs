using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace DACore.ManagementPackElements
{
    public class ManagementPackElement : XElement
    {


        #region ctors
        public ManagementPackElement(XName name)
            : base(name)
        {
            Initialize();
        }
        public ManagementPackElement(XName name, object content)
            : base(name, content)
        {
            Initialize();
        }
        public ManagementPackElement(XName name, params object[] content)
            : base(name, content)
        {
            Initialize();
        }
        public ManagementPackElement(XElement other)
            : base(other)
        {
            Initialize();
        }
        public ManagementPackElement(XStreamingElement other)
            : base(other)
        {
            Initialize();
        }
        #endregion      

        void Initialize()
        {
            this.Name = "ManagementPack";
            this.Add(new XAttribute("ContentReadable", "true"));
            this.Add(new XAttribute(XNamespace.Xmlns+"xsd", "http://www.w3.org/2001/XMLSchema"));            
            this.Add(new XElement("Manifest"));
            this.Add(new XElement("TypeDefinitions"));
            this.Add(new XElement("Monitoring"));
            this.Add(new XElement("LanguagePacks"));
        }
     
    }
}
