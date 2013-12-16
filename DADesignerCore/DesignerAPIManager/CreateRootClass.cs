
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
        string displayName;
        public CreateRootClass(ManagementPack managementPack)
        {
            _managementPack = managementPack;
        }
        public void CreateClass(ClassType rootClass)    
        {
            rootClass.Base = "System!System.Service";
            _managementPack.TypeDefinitions.EntityTypes.ClassTypes.Add(rootClass);
            displayName = rootClass.DisplayName;
        }

        public void CreateDisplayString()
        {
            DisplayString displayString = new DisplayString() { Name = displayName };
            _managementPack.LanguagePacks.LanguagePack.DisplayStrings.Add(displayString);
        }
    }
}
