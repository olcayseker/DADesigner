using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DADesignerCore.Entities
{
    public class Identity
    {
        IdentityElement element;
        public Identity(ManifestElement parent)
        {
            element = new IdentityElement(parent);
        }
        public string ID
        {
            get
            {
                return Element.Element("Manifest").Element("Identity").Element("ID").Value;
            }
            set
            {
                Element.Element("Manifest").Element("Identity").Element("ID").Value = value;
            }
        }
        public string Version
        {
            get
            {
                return Element.Element("Manifest").Element("Identity").Element("Version").Value;
            }
            set
            {
                Element.Element("Manifest").Element("Identity").Element("Version").Value = value;
            }
        }
        public IdentityElement Element {get {return element;}}
    }
}
