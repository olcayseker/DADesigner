using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.Entities
{
    public abstract class BaseEntity
    {

        public BaseEntity(XElement rootElement)
        {
            RootElement = rootElement;
        }
     //   ManagementPackElement rootElement;// = new ManagementPackElement("ManagementPack");
        protected XElement RootElement
        {
            get;
            private set;
        }

        public abstract XElement CurrentElement { get; protected set; }
    }
}
