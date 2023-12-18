using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficRulesSupervisor
{
    public class TrafficViolationNotifier : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }

        // Метод для відправлення повідомлень про порушення ПДР
        public void ReportViolation(string licensePlate, string color, string make, int fineAmount, string violatedRule)
        {
            string notification = $"Violation Report:\nLicense Plate: {licensePlate}\nColor: {color}\nMake: {make}\nFine Amount: {fineAmount}\nViolated Rule: {violatedRule}";
            NotifyObservers(notification);
        }
    }
}
