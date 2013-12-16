using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public class CreateChildClass:ICreateChild
    {
           ManagementPack _managementPack;
           ClassType classType;
           string parentid,releationShipTypeId;
           public CreateChildClass(ManagementPack managementPack)
        {
            _managementPack = managementPack;
        }
        public void CreateClass(ClassType clazzType)
        {
            parentid=clazzType.Parent.ID;
            clazzType.ID = string.Format("{0}.{1}", parentid, clazzType.SimpleName);
            _managementPack.TypeDefinitions.EntityTypes.ClassTypes.Add(clazzType);
            classType = clazzType;
        }

        public void CreateRelationshipType()
        {
            RelationshipType relationshipType = new RelationshipType();
            releationShipTypeId = string.Format("rs.{0}.Contains.{1}", classType.Parent.ID, classType.SimpleName);
            relationshipType.ID = releationShipTypeId;
            relationshipType.Source = classType.Parent.ID;
            relationshipType.Target = classType.ID;
            _managementPack.TypeDefinitions.EntityTypes.RelationshipTypes.Add(relationshipType);
        }

        public void CreateDiscoveries()
        {
            Discovery discovery = new Discovery() {
                ID = string.Format("ds.{0}", releationShipTypeId),
                Enabled=true,
                Target=parentid,
                Category = "Discovery",
                ConfirmDelivery=false,
                Remotable=true,
                Priority="Normal",
                DataSource = new DataSource() {
                ID="DS",
                TypeID="SC!Microsoft.SystemCenter.GroupPopulator",
                RuleId = "$MPElement$",
                GroupInstanceId = "$Target/Id$"                
                }
            };

            MembershipRule rule = new MembershipRule() { 
            MonitoringClass=string.Format("$MPElement[Name=\"{0}\"]$",parentid),
            RelationshipClass = string.Format("$MPElement[Name=\"{0}\"]$", releationShipTypeId)
            };

            discovery.DataSource.MembershipRules.Add(rule);
        }

        public void CreateDependencyMonitor()
        {

        }
        public void CreateDisplayString(string displayName)
        {
            DisplayString displayString = new DisplayString() { Name = displayName, Description = displayName, ElementID = classType.ID };
            _managementPack.LanguagePacks.LanguagePack.DisplayStrings.Add(displayString);
        }

     

     

    }
}
