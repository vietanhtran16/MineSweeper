using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class MineSweeperShould
    {
        [Test]
        [Ignore("Implementing other classes")]
        public void ReturnAnalysedFields()
        {
            var mineSweeper = new MineSweeper();
            const string fields = "~~~\n" +
                                  "44 \n" +
                                  "*... \n" +
                                  ".... \n" +
                                  ".*.. \n" +
                                  "....\n" +
                                  "~~~";
            var actual = mineSweeper.Sweep(fields);
            const string expected = "~~~\n" +
                                    "Field #1: \n" +
                                    "*100 \n" +
                                    "2210 \n" +
                                    "1*10 \n" +
                                    "1110\n" +
                                    "~~~";
            Assert.AreEqual(expected, actual);
        }
    }
}
