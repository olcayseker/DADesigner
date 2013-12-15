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

        ManifestElement element = new ManifestElement("Manifest");
        Identity _identity = new Identity();


        public Manifest()
        {
            References = new ReferenceCollection(element);
        }
        public Identity Identity
        {
            get
            {
                var idElement = element.Element("Identity");
                _identity.ID = idElement.Element("ID").Value;
                _identity.Version = idElement.Element("Version").Value;
                return _identity;
            }
            set
            {
                IdentityElement idElement = new IdentityElement("Identity") { ID = value.ID, Version = value.Version };
                element.AddIdentity(idElement);
            }
        }

        public string Name
        {
            get
            {
                return Element.Element("Name").Value;
            }
            set
            {
                Element.Element("Name").Value = value;
            }
        }
        public ReferenceCollection References { get; private set; }

        public ManifestElement Element { get { return element; } }
    }
}
