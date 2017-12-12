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
                Value = "...." +
                        ".*.." +
                        "..*." +
                        "...."
            };
            var actual = blah.ReadMine(field);
            const string expected = "1110" +
                                    "1*21" +
                                    "12*1" +
                                    "0111";
            Assert.AreEqual(expected, actual);
        }
    }
}