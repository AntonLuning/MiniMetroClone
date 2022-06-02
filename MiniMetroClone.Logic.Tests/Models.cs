using MiniMetroClone.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMetroClone.Logic.Tests
{
    public class Models
    {
        [Fact]
        public void StationPassengersShouldBeCollected()
        {
            Station station = new Station(new Position(0, 0), StationType.Triangle, 6);

            station.AddPassenger(new Passenger(StationType.Circle));
            station.AddPassenger(new Passenger(StationType.Circle));
            station.AddPassenger(new Passenger(StationType.Square));

            Passenger? passenger1 = station.CollectPassenger(StationType.Circle);
            Assert.NotNull(passenger1);
            Assert.Equal(2, station.Passengers.Count());

            Passenger? passenger2 = station.CollectPassenger(StationType.Triangle);
            Assert.Null(passenger2);
            Assert.Equal(2, station.Passengers.Count());
        }

        [Fact]
        public void StationSpawnPassengerShouldBeDifferentType()
        {
            Station station = new Station(new Position(0, 0), StationType.Triangle, 6);

            station.SpawnNewPassenger();
            station.SpawnNewPassenger();
            station.SpawnNewPassenger();
            station.SpawnNewPassenger();
            station.SpawnNewPassenger();

            Assert.False(station.Passengers.Where(p => p.Type == StationType.Triangle).Any());
        }
    }
}
