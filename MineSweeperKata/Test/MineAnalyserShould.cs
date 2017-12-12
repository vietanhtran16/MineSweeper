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
            var actual = mineAnalyser.ReadMine(field);
            const string expected = "1110" +
                                    "1*21" +
                                    "12*1" +
                                    "0111";
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
            var actual = mineAnalyser.ReadMine(field);
            const string expected = "**100" +
                                    "33200" +
                                    "1*100";
            Assert.AreEqual(expected, actual);
        }
    }
}