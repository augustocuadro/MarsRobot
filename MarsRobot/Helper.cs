namespace MarsRobot
{
    public static class Helper
    {
        public static (int, int) DecomposePlateauInputSize(string size)
        {
            var indexOfX = size.IndexOf('x');
            var rows = Int32.Parse(size.Substring(0, indexOfX));
            var cols = Int32.Parse(size.Substring(indexOfX + 1));

            return (rows, cols);
        }
    }
}
