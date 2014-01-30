using DACore.ManagementPackElements;
using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DADesignerCore.Entities
{
    public class Manifest
    {
        ManifestElement element;
        Identity _identity;

        public Manifest(ManagementPackElement rootElement)
        {
            element = new ManifestElement(rootElement);
            References = new ReferenceCollection(element);
            _identity = new Identity(element);
        }
        public Identity Identity
        {
            get
            {
                var idElement = Element.Element("Manifest").Element("Identity");
                _identity.ID = idElement.Element("ID").Value;
                _identity.Version = idElement.Element("Version").Value;
                return _identity;
            }
            set
            {
               // IdentityElement idElement = new IdentityElement(element.Element("Manifest")) { ID = value.ID, Version = value.Version };
                Element.Element("Manifest").Add(value.Element.Element("Manifest").Element("Identity"));
            }
        }

        public string Name
        {
            get
            {
                return Element.Element("Manifest").Element("Name").Value;
            }
            set
            {
                Element.Element("Manifest").Element("Name").Value = value;
            }
        }
        public ReferenceCollection References { get; private set; }

        public ManifestElement Element { get { return element; } }
    }
}
