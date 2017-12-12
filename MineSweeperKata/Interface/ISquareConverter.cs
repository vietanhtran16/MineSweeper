using MineSweeperKata.DTO;

namespace MineSweeperKata.Interface
{
    public interface ISquareConverter
    {
        Square ConvertToSquareBasedOnIndex(int index, Field field);
    }
}