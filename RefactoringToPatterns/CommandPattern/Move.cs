namespace RefactoringToPatterns.CommandPattern
{
    public class Move : ICommand
    {
        private MarsRover _marsRover;

        public Move(MarsRover marsRover)
        {
            _marsRover = marsRover;
        }

        public void Execute()
        {
            var move = _marsRover._movementsMap[_marsRover._direction];
            move.Execute();
        }
    }
}