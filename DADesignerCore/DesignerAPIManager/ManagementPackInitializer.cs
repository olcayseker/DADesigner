
using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public static class ManagementPackInitializer
    {

        static ManagementPackInitializer()
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
            ManagementPack = mp;
           // return mp;
        }
        //public static ManagementPack Initialize()
        //{
        //    ManagementPack mp = new ManagementPack();

        //    mp.Manifest = new Manifest();
        //    mp.Manifest.Identity = new Identity();
        //    mp.Manifest.Identity.ID = "daDesigner";
        //    mp.Manifest.Identity.Version = "1.0.0.4";
        //    mp.Manifest.Name = "daDesigner";

        //    mp.TypeDefinitions = new TypeDefinitions();
        //    mp.TypeDefinitions.EntityTypes = new EntityTypes();

        //    mp.Monitoring = new Monitoring();
        //    mp.LanguagePacks = new LanguagePacks();
        //    mp.LanguagePacks.LanguagePack = new LanguagePack();
        //    ManagementPack = mp;
        //    return mp;
        //}

        public static ManagementPack ManagementPack { get; private set; }
    }
}
