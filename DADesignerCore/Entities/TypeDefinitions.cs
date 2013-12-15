using DACore.ManagementPackElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.Entities
{
   public class TypeDefinitions
    {
       TypeDefinitionsElement element;
       EntityTypes _entityTypes;
       public TypeDefinitions()
       {
           element = new TypeDefinitionsElement("TypeDefinitions");
       }
       public EntityTypes EntityTypes
       {
           get
           {
               return _entityTypes;
           }
           set
           {
               _entityTypes = value;
               Element.RemoveNodes();
               Element.Add(_entityTypes.Element);
           }
       }

       public TypeDefinitionsElement Element { get { return element; } }
    }
}
