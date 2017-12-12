using MineSweeperKata.DTO;
using MineSweeperKata.Interface;

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
            return new Square
            {
                XCoordinate = (index < field.NoOfColumns) ? 1 : (index / field.NoOfColumns) + 1,
                YCoordinate = (index < field.NoOfColumns) ? (index + 1) : index % field.NoOfColumns + 1,
                IsBomb = (field.Value[index] == _bombSymbol)
            };
        }
    }
}