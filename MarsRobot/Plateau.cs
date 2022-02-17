namespace MarsRobot
{
    public class Plateau
    {
        public int RowCount { get; set; }
        public int ColCount { get; set; }

        public Plateau(int rowCount, int colCount)
        {
            RowCount = rowCount;
            ColCount = colCount;
        }
    }
}
