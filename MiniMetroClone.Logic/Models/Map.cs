using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Models
{
    public class Map
    {
        public MapName Name { get; }

        private readonly List<Line> _lines;
        public IEnumerable<Line> Lines => _lines;

        private readonly List<Station> _stations;
        public IEnumerable<Station> Stations => _stations;

        public Map(MapName name)
        {
            Name = name;
            _lines = new List<Line>();
            _stations = new List<Station>();
        }
    }
}
