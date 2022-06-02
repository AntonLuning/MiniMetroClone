using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public class Station : PassengerHolder
    {
        private const int SECONDS_BEFORE_TIME_OUT = 100;

        public Position Position { get; }
        public StationType Type { get; }
        public int Capacity { get; }

        private int _timeOut = 0;
        public int TimeOut
        {
            get => _timeOut;
            private set => _timeOut = Math.Max(0, value);
        }

        public Station(Position position, StationType type, int capacity) : base()
        {
            Position = position;
            Type = type;
            Capacity = capacity;
            TimeOut = 0;
        }

        public void SpawnNewPassenger()
        {
            List<StationType> types = Enum.GetValues<StationType>().ToList();
            types.Remove(Type);

            Random random = new Random();
            StationType spawnType = types[random.Next(types.Count)];

            AddPassenger(new Passenger(spawnType));
        }

        public void CalculateTimeOut()
        {
            TimeOut += Passengers.Count() - Capacity;
        }

        public bool IsTimedOut()
        {
            return TimeOut >= SECONDS_BEFORE_TIME_OUT;
        }
    }
}
