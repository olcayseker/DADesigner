using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
    public class DisplayString
    {
        DisplayStringElement element = new DisplayStringElement("DisplayString");
      //  
        public string ElementID
        {
            get
            {
                return Element.Attribute("ElementID").Value;
            }
            set
            {
                Element.Attribute("ElementID").Value = value;
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

        public string Description
        {
            get
            {
                return Element.Element("Description").Value;
            }
            set
            {
                Element.Element("Description").Value = value;
            }
        }

        public DisplayStringElement Element { get { return element; } }
    }
}
