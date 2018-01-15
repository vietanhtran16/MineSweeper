namespace MineSweeperKata
{
    public class CoordinateConverter
    {
        public int ConvertCoordToIndex(int xCoord, int yCoord, int noOfColumns)
        {
            const int startingIndexOfArray = 0;
            var startingIndexOfSpecifiedRow = startingIndexOfArray + (noOfColumns * (yCoord - 1));
            var positionWithinSpecifiedRow = xCoord - 1;
            return startingIndexOfSpecifiedRow + positionWithinSpecifiedRow;
        }
    }
}