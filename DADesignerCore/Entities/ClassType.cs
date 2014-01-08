using DADesignerCore.DesignerAPIManager;
using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DADesignerCore.Entities
{
   public class ClassType
    {
       ClassTypeElement element = new ClassTypeElement("ClassType");

       public event Action<ClassType,string> IDChanged;
        
       public string ID
       {
           get
           {
               return Element.Attribute("ID").Value;
           }
           set
           {
               if (IDChanged != null)
               {
                  // ManagementPackQueries.ChangeClassTypeID(ID, value);
                   IDChanged(this, value);
                  
               }
               //else
               //{
                   Element.Attribute("ID").Value = value;                   
              // }
           }
       }
        
        public string Accessibility
        {
            get
            {
                return Element.Attribute("Accessibility").Value;
            }
            set
            {
                Element.Attribute("Accessibility").Value = value;
            }
        }
        
        public string Base
        {
            get
            {
                return Element.Attribute("Base").Value;
            }
            set
            {
                Element.Attribute("Base").Value = value;
            }
        }


        [System.ComponentModel.ReadOnly(true)]
        public bool Abstract
        {
            get
            {
                return bool.Parse(Element.Attribute("Abstract").Value);
            }
            set
            {
                Element.Attribute("Abstract").Value = Convert.ToString(value).ToLower();
            }
        }

        [System.ComponentModel.ReadOnly(true)]
        [Description("Distributed Application icerisinde Hosted tipi kullanilmamalidir.")]
        public bool Hosted
        {
            get
            {
                return bool.Parse(Element.Attribute("Hosted").Value);
            }
            set
            {
                Element.Attribute("Hosted").Value = Convert.ToString(value).ToLower();
            }
        }

        [System.ComponentModel.ReadOnly(true)]
       [Description("Singleton grup yaratmak icin kullanilan nesne tipidir, Distributed Application yaratirken tum class tipleri singleton olarak yaratilmalidir")]
        public bool Singleton
        {
            get
            {
                return bool.Parse(Element.Attribute("Singleton").Value);
            }
            set
            {
                Element.Attribute("Singleton").Value = Convert.ToString(value).ToLower();
            }
        }

       [Browsable(false)]
        public ClassTypeElement Element
        {
            get
            {
                return element;
            }
        }

       [Browsable(false)]
        public ClassType Parent { get; set; }
       [Browsable(false)]
       public ClassType Child { get; set; }
       [Browsable(false)]
        public string SimpleName { get; set; }

        public string DisplayName { get; set; }
    }
}
