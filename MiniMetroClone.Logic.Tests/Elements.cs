using MiniMetroClone.Logic.Models;

namespace MiniMetroClone.Logic.Tests
{
    public class Elements
    {
        [Theory]
        [InlineData(0, 0, 0, 0, true)]
        [InlineData(5, 10, 5, 10, true)]
        [InlineData(-3, 6, -3, 6, true)]
        [InlineData(int.MinValue, int.MaxValue, int.MinValue, int.MaxValue, true)]
        [InlineData(-3, 6, 6, -3, false)]
        [InlineData(int.MinValue, int.MaxValue, int.MaxValue, int.MaxValue, false)]
        public void PositionsShouldBeCompared(int x1, int y1, int x2, int y2, bool expected)
        {
            Position position1 = new Position(x1, y1); 
            Position position2 = new Position(x2, y2); 

            Assert.Equal(expected, position1.Equals(position2));
        }
    }
}