using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace DADesignerCore.Entities
{
    public class Reference
    {
        ReferenceElement element;
        int internalIndex = 0;
        ManifestElement _parent;
        public Reference(ManifestElement parent,int arrayIndex)//:this()
        {
            _parent = parent;          
            _parent.Element("Manifest").Element("References").Add(element);

            if (arrayIndex > -1)
                internalIndex = arrayIndex;
            else
                internalIndex = _parent.Element("Manifest").Descendants("Reference").Count() - 1;
        }

        public Reference()
        {
            element = new ReferenceElement("Reference");
        }
       
        public string Alias
        {
            get
            {
                if(_parent !=null)
                    return _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Attribute("Alias").Value;
                else
                    return Element.Attribute("Alias").Value;
            }
            set
            {
                if (_parent != null)
                    _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Attribute("Alias").Value = value;
                else
                    Element.Attribute("Alias").Value = value;
               
            }
        }
        public string ID
        {
            get
            {
                if (_parent != null)
                    return _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("ID").Value;
                else
                    return Element.Element("ID").Value;
                
            }
            set
            {
                if (_parent != null)
                    _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("ID").Value = value;
                else
                    Element.Element("ID").Value = value;
                
            }
        }
        public string Version
        {
            get
            {
                if (_parent != null)
                    return _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("Version").Value;
                 else
                    return Element.Element("Version").Value;
            }
            set
            {
                if (_parent != null)
                    _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("Version").Value = value;
                else
                    Element.Element("Version").Value = value;
                
            }
        }     
        public string PublicKeyToken
        {
            get
            {
                if (_parent != null)
                    return _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("PublicKeyToken").Value; 
                 else
                    return Element.Element("PublicKeyToken").Value; 
            }
            set
            {
                if (_parent != null)
                    _parent.Element("Manifest").Descendants("Reference").ElementAt(internalIndex).Element("PublicKeyToken").Value = value;
                else
                    Element.Element("PublicKeyToken").Value = value;
                
            }
        }   

        public ReferenceElement Element { get { return element; } }

      
    }
}
