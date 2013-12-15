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
        public Identity()
        {
            element = new IdentityElement("Identity");
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
        public IdentityElement Element {get {return element;}}
    }
}
