using System;
using MineSweeperKata.DTO;

namespace MineSweeperKata
{
    public class MineAnalyser
    {
        private readonly ISquareConverter _squareConverter;
        private readonly SurroundingChecker _surroundingChecker;

        public MineAnalyser()
        {
            _squareConverter = new SquareConverter();
            _surroundingChecker = new SurroundingChecker();
        }

        public string ReadMine(Field field)
        {
            var analysedField = string.Empty;
            for (var index = 0; index < field.Value.Length; index++)
            {
                var square = _squareConverter.ConvertToSquareBasedOnIndex(index, field);
                analysedField += _surroundingChecker.Check(square, field);
            }
            return analysedField;
        }
    }
}