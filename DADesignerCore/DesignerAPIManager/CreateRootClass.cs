
using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public class CreateRootClass:ICreateRoot
    {
        ManagementPack _managementPack;
        public CreateRootClass(ManagementPack managementPack)
        {
            _managementPack = managementPack;
        }
        public void CreateClass(ClassType rootClass)    
        {
            _managementPack.TypeDefinitions.EntityTypes.ClassTypes.Add(rootClass);
        }

        public void CreateDisplayString(string displayName)
        {
            DisplayString displayString = new DisplayString() { Name = displayName };
            _managementPack.LanguagePacks.LanguagePack.DisplayStrings.Add(displayString);
        }
    }
}
