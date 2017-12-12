using System;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class SurroundingChecker
    {
        private readonly CoordinateConverter _coordinateConverter;
        private readonly char _bombSymbol;
        public SurroundingChecker()
        {
            _coordinateConverter = new CoordinateConverter();
            _bombSymbol = '*';
        }
        public string CheckBomb(Square square, Field field)
        {
            if (square.IsBomb) return _bombSymbol.ToString();

            var bombCount = 0;
            var minX = Math.Max(1, square.XCoordinate - 1);
            var maxX = Math.Min(field.NoOfRows, square.XCoordinate + 1);
            var minY = Math.Max(1, square.YCoordinate - 1);
            var maxY = Math.Min(field.NoOfColumns, square.YCoordinate + 1);

            for (var x = minX; x <= maxX; x++)
            {
                for (var y = minY; y <= maxY; y++)
                {
                    if(x == square.XCoordinate && y == square.YCoordinate) continue;
                    if (field.Value[_coordinateConverter.ConvertCoordToIndex(x, y, field.NoOfColumns)] == _bombSymbol)
                        bombCount++;
                }
            }
            return bombCount.ToString();
        }
    }
}