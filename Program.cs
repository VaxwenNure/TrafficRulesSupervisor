using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Створення спостережуваного об'єкта
            TrafficViolationNotifier notifier = new TrafficViolationNotifier();

            // Створення спостерігачів
            TrafficPolice trafficPolice = new TrafficPolice();
            CourtBailiff courtBailiff = new CourtBailiff();

            // Додавання спостерігачів до спостережуваного об'єкта
            notifier.AddObserver(trafficPolice);
            notifier.AddObserver(courtBailiff);

            // відправлення повідомлення про порушення
            notifier.ReportViolation("AB123CD", "Blue", "Toyota", 100, "Speeding");

            Console.ReadLine();
        }
    }
}
