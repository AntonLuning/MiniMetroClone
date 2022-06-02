using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public abstract class PassengerHolder
    {
        private readonly List<Passenger> _passengers;
        public IEnumerable<Passenger> Passengers => _passengers;

        protected PassengerHolder()
        {
            _passengers = new List<Passenger>();
        }

        public void AddPassenger(Passenger passenger)
        {
            if (passenger == null)
            {
                return;
            }

            _passengers.Add(passenger);
        }

        public Passenger? CollectPassenger(StationType stationType)
        {
            Passenger? passengerToRemove = Passengers.Where(p => p.Type == stationType).FirstOrDefault();

            if (passengerToRemove == null)
            {
                return null;
            }

            _passengers.Remove(passengerToRemove);

            return passengerToRemove;
        }

        public bool ContainsPassenger(StationType type)
        {
            return Passengers.Where(p => p.Type == type).Any();
        }
    }
}
