using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public class CourtBailiff : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Court Bailiff received notification:\n{message}");
        }
    }
}
