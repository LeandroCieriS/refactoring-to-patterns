using System.Collections.Generic;

namespace RefactoringToPatterns.CommandPattern
{
    public class MarsRover
    {
        public int _x;
        public int _y;
        public char _direction;
        public readonly string _availableDirections = "NESW";
        public readonly string[] _obstacles;
        public bool _obstacleFound;
        private readonly MovementsEast _movementsEast;
        private readonly MovementsNorth _movementsNorth;
        private readonly MovementsWest _movementsWest;
        private readonly MovementsSouth _movementsSouth;
        public Dictionary<char, IMovements> _movementsMap = new Dictionary<char, IMovements>();

        private readonly RotateRight _rotateRight;
        private readonly RotateLeft _rotateLeft;
        private readonly Move _move;
        public Dictionary<char, ICommand> _commandsMap = new Dictionary<char, ICommand>();


        public MarsRover(int x, int y, char direction, string[] obstacles)
        {
            _x = x;
            _y = y;
            _direction = direction;
            _obstacles = obstacles;

            _movementsEast = new MovementsEast(this);
            _movementsNorth = new MovementsNorth(this);
            _movementsWest = new MovementsWest(this);
            _movementsSouth = new MovementsSouth(this);
            _movementsMap.Add('E', _movementsEast);
            _movementsMap.Add('W', _movementsWest);
            _movementsMap.Add('N', _movementsNorth);
            _movementsMap.Add('S', _movementsSouth);

            _rotateRight = new RotateRight(this);
            _rotateLeft = new RotateLeft(this);
            _move = new Move(this);
            _commandsMap.Add('M', _move);
            _commandsMap.Add('L', _rotateLeft);
            _commandsMap.Add('R', _rotateRight);
        }

        public string GetState()
        {
            return !_obstacleFound ? $"{_x}:{_y}:{_direction}" : $"O:{_x}:{_y}:{_direction}";
        }

        public void Execute(string commands)
        {
            foreach (var command in commands)
            {
                _commandsMap[command].Execute();
            }
        }
    }
}