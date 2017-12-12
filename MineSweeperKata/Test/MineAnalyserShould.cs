using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class MineAnalyserShould
    {
        [Test]
        public void Read4By4Field()
        {
            var mineAnalyser = new MineAnalyser();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "...." +
                        ".*.." +
                        "..*." +
                        "...."
            };
            var actual = mineAnalyser.Read(field);
            const string expected = "1110\n" +
                                    "1*21\n" +
                                    "12*1\n" +
                                    "0111\n";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Read3By5Field()
        {
            var mineAnalyser = new MineAnalyser();
            var field = new Field()
            {
                NoOfRows = 3,
                NoOfColumns = 5,
                Value = "**..." +
                        "....." +
                        ".*..."
            };
            var actual = mineAnalyser.Read(field);
            const string expected = "**100\n" +
                                    "33200\n" +
                                    "1*100\n";
            Assert.AreEqual(expected, actual);
        }
    }
}