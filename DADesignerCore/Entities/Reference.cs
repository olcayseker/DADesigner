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
       // [XmlAttribute]
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

        //public override bool Equals(object obj)
        //{
        //    var other = obj as Reference;
        //    Debugger.Break();
        //    if (other == null)
        //        return false;

        //    if (ReferenceEquals(this, other))
        //        return true;

        //    if (this.GetHashCode() != other.GetHashCode())
        //        return false;


        //    return this.PublicKeyToken.Equals(other.PublicKeyToken);
            
        //}

        //public override int GetHashCode()
        //{
        //    if (string.IsNullOrWhiteSpace(this.PublicKeyToken))
        //        return this.element.Name.GetHashCode() * 4;

        //    unchecked
        //    {
        //        return this.PublicKeyToken.GetHashCode() + this.element.Name.GetHashCode() * 4;
        //    }
        //}
    }
}
