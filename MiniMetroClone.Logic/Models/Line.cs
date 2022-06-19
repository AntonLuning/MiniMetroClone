using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public class Line
    {
        public LineColor Color { get; }

        private readonly List<Station> _stations;
        public IEnumerable<Station> Stations => _stations;

        private readonly List<Train> _trains;
        public IEnumerable<Train> Trains => _trains;

        public Line(LineColor color)
        {
            Color = color;
            _stations = new List<Station>();
            _trains = new List<Train>();
        }
    }
}
