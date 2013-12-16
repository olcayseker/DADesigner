
using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DADesignerCore.DesignerAPIManager
{
    public interface ICreateRoot
    {
        void CreateClass(ClassType clazzType);
        void CreateDisplayString();
    }
}
