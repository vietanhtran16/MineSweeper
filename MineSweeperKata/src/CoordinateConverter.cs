namespace MineSweeperKata
{
    public class CoordinateConverter
    {
        public int ConvertCoordToIndex(int xCoord, int yCoord, int noOfColumns)
        {
            const int startingIndexOfArray = 0;
            var startingIndexOfSpecifiedRow = startingIndexOfArray + (noOfColumns * (xCoord - 1));
            var positionWithinSpecifiedRow = yCoord - 1;
            return startingIndexOfSpecifiedRow + positionWithinSpecifiedRow;
        }
    }
}