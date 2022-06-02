using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public class Train : PassengerHolder
    {
        public int Capacity { get; }

        public Train(int capacity) : base()
        {
            Capacity = capacity;
        }

        public bool IsFull()
        {
            return Passengers.Count() == Capacity;
        }
    }
}
