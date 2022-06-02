using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public class Passenger
    {
        public StationType Type { get; }

        public Passenger(StationType type)
        {
            Type = type;
        }
    }
}
