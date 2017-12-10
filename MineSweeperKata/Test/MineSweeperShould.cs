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
                                  "~~~\n\n" +
                                  "~~~\n" +
                                  "35 \n" +
                                  "**... \n" +
                                  "..... \n" +
                                  ".*...\n" +
                                  "~~~";
            var actual = mineSweeper.DoSomething(fields);
            const string expected = "~~~\n" +
                                    "Field #1: \n" +
                                    "*100 \n" +
                                    "2210 \n" +
                                    "1*10 \n" +
                                    "1110\n" +
                                    "~~~\n\n" +
                                    "~~~\n" +
                                    "Field #2: \n" +
                                    "**100 \n" +
                                    "33200 \n" +
                                    "1*100\n" +
                                    "~~~";
            Assert.AreEqual(expected, actual);
        }
    }
}
