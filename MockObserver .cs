using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public class MockObserver : IObserver
    {
        public bool IsUpdateCalled { get; private set; }
        public string LastMessage { get; private set; }

        public void Update(string message)
        {
            IsUpdateCalled = true;
            LastMessage = message;
        }
    }
}
