using DADesignerCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.DesignerAPIManager
{
    public class CreateChildClass : ICreateChild
    {
        ManagementPack _managementPack;
        ClassType classType;
        RelationshipType relationshipType;
        string parentid, releationShipTypeId;
        public CreateChildClass(ManagementPack managementPack)
        {
            _managementPack = managementPack;
        }
        public void CreateClass(ClassType clazzType)
        {
            classType.Base = "MSSL!Microsoft.SystemCenter.ServiceDesigner.ServiceComponentGroup";
            parentid = clazzType.Parent.ID;
            clazzType.ID = string.Format("{0}.{1}", parentid, clazzType.SimpleName);
            _managementPack.TypeDefinitions.EntityTypes.ClassTypes.Add(clazzType);
            classType = clazzType;
        }

        public void CreateRelationshipType()
        {
            relationshipType = new RelationshipType();
            releationShipTypeId = string.Format("rs.{0}.Contains.{1}", classType.Parent.ID, classType.SimpleName);
            relationshipType.ID = releationShipTypeId;
            relationshipType.Source = classType.Parent.ID;
            relationshipType.Target = classType.ID;
            _managementPack.TypeDefinitions.EntityTypes.RelationshipTypes.Add(relationshipType);
        }

        public void CreateDiscoveries()
        {
            Discovery discovery = new Discovery()
            {
                ID = string.Format("ds.{0}", releationShipTypeId),
                Enabled = true,
                Target = parentid,
                Category = "Discovery",
                ConfirmDelivery = false,
                Remotable = true,
                Priority = "Normal",
                DataSource = new DataSource()
                {
                    ID = "DS",
                    TypeID = "SC!Microsoft.SystemCenter.GroupPopulator",
                    RuleId = "$MPElement$",
                    GroupInstanceId = "$Target/Id$"
                }
            };

            MembershipRule rule = new MembershipRule()
            {
                MonitoringClass = string.Format("$MPElement[Name=\"{0}\"]$", parentid),
                RelationshipClass = string.Format("$MPElement[Name=\"{0}\"]$", releationShipTypeId)
            };

            discovery.DataSource.MembershipRules.Add(rule);
            _managementPack.Monitoring.Discoveries.Add(discovery);
        }

        public void CreateDependencyMonitor()
        {
            DependencyMonitor availability = new DependencyMonitor();
            availability.ID = string.Format("mon.{0}.AvailabilityState", relationshipType.Target);
            availability.Accessibility = "Public";
            availability.Enabled = true;
            availability.Target = relationshipType.Source;
            availability.MemberMonitor = availability.ParentMonitorID = "Health!System.Health.AvailabilityState";
            availability.Remotable = true;
            availability.Priority = "Normal";
            availability.RelationshipType = releationShipTypeId;
            availability.Category = "AvailabilityHealth";
            availability.Algorithm = "WorstOf";

            _managementPack.Monitoring.Monitors.Add(availability);

            DependencyMonitor performanceState = new DependencyMonitor();
            performanceState.ID = string.Format("mon.{0}.PerformanceState", relationshipType.Target);
            performanceState.Accessibility = "Public";
            performanceState.Enabled = true;
            performanceState.Target = relationshipType.Source;
            performanceState.MemberMonitor = performanceState.ParentMonitorID = "Health!System.Health.PerformanceState";
            performanceState.Remotable = true;
            performanceState.Priority = "Normal";
            performanceState.RelationshipType = releationShipTypeId;
            performanceState.Category = "PerformanceHealth";
            performanceState.Algorithm = "WorstOf";

            _managementPack.Monitoring.Monitors.Add(performanceState);

            DependencyMonitor securityState = new DependencyMonitor();
            securityState.ID = string.Format("mon.{0}.SecurityState", relationshipType.Target);
            securityState.Accessibility = "Public";
            securityState.Enabled = true;
            securityState.Target = relationshipType.Source;
            securityState.MemberMonitor = securityState.ParentMonitorID = "Health!System.Health.SecurityState";
            securityState.Remotable = true;
            securityState.Priority = "Normal";
            securityState.RelationshipType = releationShipTypeId;
            securityState.Category = "SecurityHealth";
            securityState.Algorithm = "WorstOf";

            _managementPack.Monitoring.Monitors.Add(securityState);

            DependencyMonitor configurationState = new DependencyMonitor();
            configurationState.ID = string.Format("mon.{0}.ConfigurationState", relationshipType.Target);
            configurationState.Accessibility = "Public";
            configurationState.Enabled = true;
            configurationState.Target = relationshipType.Source;
            configurationState.MemberMonitor = configurationState.ParentMonitorID = "Health!System.Health.ConfigurationState";
            configurationState.Remotable = true;
            configurationState.Priority = "Normal";
            configurationState.RelationshipType = releationShipTypeId;
            configurationState.Category = "ConfigurationHealth";
            configurationState.Algorithm = "WorstOf";

            _managementPack.Monitoring.Monitors.Add(securityState);
        }
        public void CreateDisplayString()
        {
            DisplayString displayString = new DisplayString() { Name = classType.DisplayName, Description = classType.DisplayName, ElementID = classType.ID };
            _managementPack.LanguagePacks.LanguagePack.DisplayStrings.Add(displayString);
        }





    }
}
