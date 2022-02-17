namespace MarsRobot
{
    public class Robot
    {
        public CardinalPoint FacingPosition;
        public Position Position { get; set; }
        public Plateau Plateau { get; set; }

        public Robot(Plateau plateau)
        {
            FacingPosition = CardinalPoint.North;
            Position = new Position(1, 1);
            Plateau = plateau;
        }

        public void ProcessCommands(string commands)
        {
            foreach (var command in commands.ToCharArray())
            {
                Move(command);
            }
        }

        private void Move(char command)
        {
            switch (command)
            {
                case 'L':
                    TurnLeft();
                    break;
                case 'R':
                    TurnRight();
                    break;
                case 'F':
                    if (CanMoveForward())
                        MoveForward();
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (FacingPosition)
            {
                case CardinalPoint.North:
                    FacingPosition = CardinalPoint.West;
                    break;
                case CardinalPoint.East:
                    FacingPosition = CardinalPoint.North;
                    break;
                case CardinalPoint.South:
                    FacingPosition = CardinalPoint.East;
                    break;
                case CardinalPoint.West:
                    FacingPosition = CardinalPoint.South;
                    break;
            }
        }

        private void TurnRight()
        {
            switch (FacingPosition)
            {
                case CardinalPoint.North:
                    FacingPosition = CardinalPoint.East;
                    break;
                case CardinalPoint.East:
                    FacingPosition = CardinalPoint.South;
                    break;
                case CardinalPoint.South:
                    FacingPosition = CardinalPoint.West;
                    break;
                case CardinalPoint.West:
                    FacingPosition = CardinalPoint.North;
                    break;
            }
        }

        private void MoveForward()
        {
            switch (FacingPosition)
            {
                case CardinalPoint.North:
                    Position.PositionY++;
                    break;
                case CardinalPoint.East:
                    Position.PositionX++;
                    break;
                case CardinalPoint.South:
                    Position.PositionY--;
                    break;
                case CardinalPoint.West:
                    Position.PositionX--;
                    break;
            }
        }

        private bool CanMoveForward()
        {
            switch (FacingPosition)
            {
                case CardinalPoint.North:
                    if (Position.PositionY == Plateau.RowCount)
                        return false;
                    break;
                case CardinalPoint.East:
                    if (Position.PositionX == Plateau.ColCount)
                        return false;
                    break;
                case CardinalPoint.South:
                    if (Position.PositionY == 1)
                        return false;
                    break;
                case CardinalPoint.West:
                    if (Position.PositionX == 1)
                        return false;
                    break;
            }
            return true;
        }
    }
}
