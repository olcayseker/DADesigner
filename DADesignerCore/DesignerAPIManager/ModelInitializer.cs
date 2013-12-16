
using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public class ModelInitializer
    {
        public ManagementPack Initialize()
        {
            ManagementPack mp = new ManagementPack();

            mp.Manifest = new Manifest();
            mp.Manifest.Identity = new Identity();
            mp.Manifest.Identity.ID = "daDesigner";
            mp.Manifest.Identity.Version = "1.0.0.4";
            mp.Manifest.Name = "daDesigner";

            mp.TypeDefinitions = new TypeDefinitions();
            mp.TypeDefinitions.EntityTypes = new EntityTypes();

            mp.Monitoring = new Monitoring();
            mp.LanguagePacks = new LanguagePacks();
            mp.LanguagePacks.LanguagePack = new LanguagePack();

            return mp;
        }
    }
}
