using MarsRobot;

Console.WriteLine("Robot App");
char answer;

do
{
    Console.Write("Plateau size (e.g. 5x5): ");
    var size = Console.ReadLine();
    var rows = Helper.DecomposePlateauInputSize(size).Item1;
    var cols = Helper.DecomposePlateauInputSize(size).Item2;

    var plateau = new Plateau(rows, cols);
    var robot = new Robot(plateau);

    Console.Write("Movement commands (e.g. FFRFLFLF): ");
    var commands = Console.ReadLine();

    robot.ProcessCommands(commands);
    Console.WriteLine("Final position:");
    Console.WriteLine(string.Concat(robot.Position.PositionX, ", ", robot.Position.PositionY, ", ", Enum.GetName(robot.FacingPosition)));

    do
    {
        Console.Write("Repeat? [Y/N]: ");
        answer = Console.ReadLine().ToUpper()[0];
    } while (answer != 'Y' && answer != 'N');

} while (answer is 'Y');