using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
  
    public class ManagementPack
    {

        ManagementPackElement element = new ManagementPackElement("ManagementPack");
        Manifest manifest;
        TypeDefinitions typeDefinitions;
        Monitoring monitoring;
        LanguagePacks languagePacks;
     
       // 
        public bool ContentReadable
        {
            get
            {
                return bool.Parse(Element.Attribute("ContentReadable").Value);
            }
            set
            {
                Element.Attribute("ContentReadable").Value = value.ToString().ToLower();
            }
        }

        public Manifest Manifest
        {
            get
            {
                return manifest;
            }
            set
            {
                manifest = value;
                Element.Element("Manifest").Remove();
                Element.Add(manifest.Element);
            }
        }

        public TypeDefinitions TypeDefinitions
        {
            get
            {
                return typeDefinitions;
            }
            set
            {
                typeDefinitions = value;
                Element.Element("TypeDefinitions").Remove();
                Element.Add(typeDefinitions.Element);
            }
        }

        public Monitoring Monitoring
        {
            get
            {
                return monitoring;
            }
            set
            {
                monitoring = value;
                Element.Element("Monitoring").Remove();
                Element.Add(monitoring.Element);
            }
        }

        public LanguagePacks LanguagePacks
        {
            get
            {
                return languagePacks;
            }
            set
            {
                languagePacks = value;
                Element.Element("LanguagePacks").Remove();
                Element.Add(languagePacks.Element);
            }
        }

        public ManagementPackElement Element { get { return element; } }
    }
}
