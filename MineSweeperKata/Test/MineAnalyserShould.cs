using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class MineAnalyserShould
    {
        [Test]
        public void DoSomething()
        {
            var blah = new MineAnalyser();
            var field = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
            };
            var actual = blah.ReadMine(field);
            var expected = "*100\n" +
                           "2210\n" +
                           "1*10\n" +
                           "1110\n";
            Assert.AreEqual(expected, actual);
        }
    }
}