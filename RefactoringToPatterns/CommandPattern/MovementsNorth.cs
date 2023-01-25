using System.Collections;

namespace RefactoringToPatterns.CommandPattern
{
    public class MovementsNorth : IMovements
    {
        private MarsRover _marsRover;

        public MovementsNorth(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void Execute()
        {
            _marsRover._obstacleFound = ((IList)_marsRover._obstacles).Contains($"{_marsRover._x}:{_marsRover._y - 1}");
            // check if rover reached plateau limit or found an obstacle
            _marsRover._y = _marsRover._y > 0 && !_marsRover._obstacleFound ? _marsRover._y -= 1 : _marsRover._y;
        }
    }
}