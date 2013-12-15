using DACore.ManagementPackElements;
using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DADesignerCore.Entities
{
    public class EntityTypes
    {
        EntityTypesElement element;
        
        public EntityTypes()
        {
            element = new EntityTypesElement("EntityTypes");
            ClassTypes = new ClassTypeCollection(element);
            RelationshipTypes = new RelationshipTypeCollection(element);
        }
        public ClassTypeCollection ClassTypes { get; private set; }
        public RelationshipTypeCollection RelationshipTypes { get; private set; }

        public EntityTypesElement Element { get { return element; } }
    }
}
