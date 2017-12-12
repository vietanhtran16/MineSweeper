using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public interface ISquareConverter
    {
        Square ConvertToSquareBasedOnIndex(int index, Field field);
    }
}