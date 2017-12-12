using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class SquareConverterShould
    {

        [Test]
        public void ReturnBombSquareObjBasedOnItsPositionOnField()
        {
            var squareConverter = new SquareConverter();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
            };
            const int index = 9;
            var actual = squareConverter.ConvertToSquareBasedOnIndex(index, field);
            var expected = new Square()
            {
                XCoordinate = 3,
                YCoordinate = 2,
                IsBomb = true
            };
            Assert.AreEqual(expected.XCoordinate, actual.XCoordinate);
            Assert.AreEqual(expected.YCoordinate, actual.YCoordinate);
            Assert.AreEqual(expected.IsBomb, actual.IsBomb);
        }

        [Test]
        public void ReturnNonBombSquareObjBasedOnItsPositionOnField()
        {
            var squareConverter = new SquareConverter();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 5,
                Value = "*...." +
                        "....." +
                        ".*..." +
                        "....."
            };
            const int index = 12;
            var actual = squareConverter.ConvertToSquareBasedOnIndex(index, field);
            var expected = new Square()
            {
                XCoordinate = 3,
                YCoordinate = 3,
                IsBomb = false
            };
            Assert.AreEqual(expected.XCoordinate, actual.XCoordinate);
            Assert.AreEqual(expected.YCoordinate, actual.YCoordinate);
            Assert.AreEqual(expected.IsBomb, actual.IsBomb);
        }

        [Test]
        public void ReturnTopRightCornerSquareObj()
        {
            var squareConverter = new SquareConverter();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
            };
            const int index = 15;
            var actual = squareConverter.ConvertToSquareBasedOnIndex(index, field);
            var expected = new Square()
            {
                XCoordinate = 4,
                YCoordinate = 4,
                IsBomb = false
            };
            Assert.AreEqual(expected.XCoordinate, actual.XCoordinate);
            Assert.AreEqual(expected.YCoordinate, actual.YCoordinate);
            Assert.AreEqual(expected.IsBomb, actual.IsBomb);
        }
    }
}