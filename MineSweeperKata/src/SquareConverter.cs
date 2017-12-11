using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class SquareConverter
    {
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
                xCoord = index / (field.NoOfColumns - 1);
                yCoord = index % field.NoOfColumns + 1;
            }

            if (field.Value[index] == '*')
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