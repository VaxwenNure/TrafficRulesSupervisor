using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public interface IObserver
    {
        void Update(string message);
    }
}
