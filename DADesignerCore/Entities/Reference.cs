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
        ReferenceElement element = new ReferenceElement("Reference");
       // 
        public string Alias
        {
            get
            {
                return element.Alias;
            }
            set
            {
                element.Alias = value;
            }
        }
        public string ID
        {
            get
            {
                return element.ID;
            }
            set
            {
                element.ID = value;
            }
        }
        public string Version
        {
            get
            {
                return element.Version;
            }
            set
            {
                element.Version = value;
            }
        }     
        public string PublicKeyToken
        {
            get
            {
                return element.PublicKeyToken;
            }
            set
            {
                element.PublicKeyToken = value;
            }
        }   

        public ReferenceElement Element { get { return element; } }

      
    }
}
