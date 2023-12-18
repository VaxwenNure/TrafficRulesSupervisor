using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public class TrafficPolice : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Traffic Police received notification:\n{message}");
        }
    }
}
