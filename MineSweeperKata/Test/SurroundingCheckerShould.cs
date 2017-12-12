using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class SurroundingCheckerShould
    {
        [Test]
        public void ReturnNoOfBombsSurroundingSquare()
        {
            var surroundingChecker = new SurroundingChecker();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
            };
            var square = new Square
            {
                XCoordinate = 2,
                YCoordinate = 2,
                IsBomb = false,
            };

            var actual = surroundingChecker.CheckBomb(square, field);
            var expected = "2";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnBombSymbolIfSquareContainsBomb()
        {
            var surroundingChecker = new SurroundingChecker();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        "...." +
                        ".*.."
            };
            var square = new Square
            {
                XCoordinate = 4,
                YCoordinate = 2,
                IsBomb = true,
            };

            var actual = surroundingChecker.CheckBomb(square, field);
            var expected = "*";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnZeroWhenThereIsNoBombSurrounding()
        {
            var surroundingChecker = new SurroundingChecker();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
            };
            var square = new Square
            {
                XCoordinate = 4,
                YCoordinate = 4,
                IsBomb = false,
            };

            var actual = surroundingChecker.CheckBomb(square, field);
            var expected = "0";
            Assert.AreEqual(expected, actual);
        }
    }
}   