using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DADesignerCore.DesignerAPIManager
{
    public static class ManagementPackQueries
    {
        public static void ChangeClassTypeID(string oldID,string newID)
        {
            var classTypes = ManagementPackInitializer.ManagementPack.Element.Element("TypeDefinitions").Descendants("ClassType")
                .Where(z=>z.Attribute("ID").Value.Contains(oldID));

            foreach (XElement item in classTypes)
            {
                item.Attribute("ID").Value = item.Attribute("ID").Value.Replace(oldID, newID);
                
                //Element.Attribute("ID").Value = item.Attribute("ID").Value;
            }

            var relationshipTypes = ManagementPackInitializer.ManagementPack.Element.Element("TypeDefinitions").Descendants("RelationshipType")
                .Where(z => z.Attribute("ID").Value.Contains(oldID));

            foreach (XElement item in relationshipTypes)
            {
                item.Attribute("ID").Value = item.Attribute("ID").Value.Replace(oldID, newID);
                item.Element("Source").Value = item.Element("Source").Value.Replace(oldID, newID);
                item.Element("Target").Value = item.Element("Target").Value.Replace(oldID, newID);
            }

            var discoveries = ManagementPackInitializer.ManagementPack.Element.Element("Monitoring").Descendants("Discovery")
               .Where(z => z.Attribute("ID").Value.Contains(oldID));

            foreach (XElement item in discoveries)
            {
                item.Attribute("ID").Value = item.Attribute("ID").Value.Replace(oldID, newID);
            }
           
        }

        
    }
}
