using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class SquareConverter : ISquareConverter
    {
        private readonly char _bombSymbol;
        public SquareConverter()
        {
            _bombSymbol = '*';
        }
        public Square ConvertToSquareBasedOnIndex(int index, Field field)
        {
            int xCoord;
            int yCoord;
            var isBomb = false;

            if (index < field.NoOfColumns)
            {
                xCoord = 1;
                yCoord = index + 1;
            }
            else
            {
                xCoord = (index / field.NoOfColumns) + 1;
                yCoord = index % field.NoOfColumns + 1;
            }

            if (field.Value[index] == _bombSymbol)
                isBomb = true;

            return new Square
            {
                XCoordinate = xCoord,
                YCoordinate = yCoord,
                IsBomb = isBomb
            };
        }
    }
}