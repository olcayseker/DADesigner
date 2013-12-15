using DADesignerCore.EntityElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DADesignerCore.Entities
{
   public class Monitoring
    {
       MonitoringElement element;
       public Monitoring()
       {
           element = new MonitoringElement("Monitoring");
           Discoveries = new DiscoveryCollection(element);
           Monitors = new DependencyMonitorCollection(element);
       }
       public DiscoveryCollection Discoveries { get; private set; }
       public DependencyMonitorCollection Monitors { get; private set; }

       public MonitoringElement Element { get { return element; } }
    }
}
