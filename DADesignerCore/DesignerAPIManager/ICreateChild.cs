using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DADesignerCore.DesignerAPIManager
{
    public interface ICreateChild:ICreateRoot
    {
        void CreateRelationshipType();
        void CreateDiscoveries();
        void CreateDependencyMonitor();
    }
}
