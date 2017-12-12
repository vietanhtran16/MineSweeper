using System;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class SurroundingChecker
    {
        private readonly char _bombSymbol;
        public SurroundingChecker()
        {
            _bombSymbol = '*';
        }
        public string Check(Square square, Field field)
        {
            if (square.IsBomb) return _bombSymbol.ToString();

            var bombCount = 0;
            var minX = Math.Max(1, square.XCoordinate - 1);
            var maxX = Math.Min(field.NoOfColumns - 1, square.XCoordinate + 1);
            var minY = Math.Max(1, square.YCoordinate - 1);
            var maxY = Math.Min(field.NoOfRows - 1, square.YCoordinate + 1);

            for (var x = minX; x <= maxX; x++)
            {
                for (var y = minY; y <= maxY; y++)
                {
                    if(x == square.XCoordinate && y == square.YCoordinate) continue;
                    if (field.Value[ConvertCoordToIndex(x, y, field.NoOfColumns)] == _bombSymbol)
                        bombCount++;
                }
            }
            return bombCount.ToString();
        }

        private int ConvertCoordToIndex(int xCoord, int yCoord, int noOfColumns)
        {
            const int startingIndexOfArray = 0;
            var startingIndexOfSpecifiedRow = startingIndexOfArray + (noOfColumns * (xCoord - 1));
            var positionWithinSpecifiedRow = yCoord - 1;
            return startingIndexOfSpecifiedRow + positionWithinSpecifiedRow;
        }
    }
}