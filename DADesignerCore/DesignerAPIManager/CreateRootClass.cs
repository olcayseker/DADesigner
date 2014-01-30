
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
        //ManagementPack _managementPack;
        string displayName;
        public CreateRootClass()
        {
           // _managementPack = managementPack;
        }
        public void CreateClass(ClassType rootClass)    
        {
            rootClass.Base = "System!System.Service";
            ManagementPack.TypeDefinitions.EntityTypes.ClassTypes.Add(rootClass);
            displayName = rootClass.DisplayName;
           // rootClass.IDChanged += rootClass_IDChanged;
        }

        //void rootClass_IDChanged(object sender, string e)
        //{
        //    //throw new NotImplementedException();
        //}

        public void CreateDisplayString()
        {
            DisplayString displayString = new DisplayString() { Name = displayName,ElementID=displayName,Description=displayName };
            ManagementPack.LanguagePacks.LanguagePack.DisplayStrings.Add(displayString);
        }

        public ManagementPack ManagementPack { get; set; }
    }
}
