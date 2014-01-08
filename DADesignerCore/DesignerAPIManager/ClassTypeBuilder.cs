using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public class ClassTypeBuilder
    {
        ICreateRoot createRoot;
        ICreateChild createChild;
        public ClassTypeBuilder(ICreateRoot rootCreator,ICreateChild childCreator,ManagementPack pack)
        {
            ManagementPack = pack;
            createRoot = rootCreator;
            createChild = childCreator;
            createRoot.ManagementPack = createChild.ManagementPack = pack;
        }

        public void BuildRootClass(ClassType rootClass)
        {
            //createRoot.
            createRoot.CreateClass(rootClass);
            createRoot.CreateDisplayString();
        }

        public void BuildChildClass(ClassType childClass)
        {
            createChild.CreateClass(childClass);
            createChild.CreateRelationshipType();
            createChild.CreateDiscoveries();
            createChild.CreateDependencyMonitor();
            createChild.CreateDisplayString();     
        }

        public ManagementPack ManagementPack { get; private set; }
    }
}
