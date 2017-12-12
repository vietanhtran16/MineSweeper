using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class MineSweeperShould
    {
        [Test]
        public void ReturnSingleAnalysedField()
        {
            var mineSweeper = new MineSweeper();
            const string fields = "~~~\n" +
                                  "44\n" +
                                  "*...\n" +
                                  "....\n" +
                                  ".*..\n" +
                                  "....\n" +
                                  "~~~";
            var actual = mineSweeper.Sweep(fields);
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "*100\n" +
                                    "2210\n" +
                                    "1*10\n" +
                                    "1110\n" +
                                    "~~~\n" +
                                    "\n";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnMultiAnalysedFields()
        {
            var mineSweeper = new MineSweeper();
            const string fields = "~~~\n" +
                                  "44\n" +
                                  "*...\n" +
                                  "....\n" +
                                  ".*..\n" +
                                  "....\n" +
                                  "~~~\n" + 
                                  "\n" +
                                  "~~~\n" +
                                  "35\n" +
                                  "**...\n" +
                                  ".....\n" +
                                  ".*...\n" +
                                  "~~~";
            var actual = mineSweeper.Sweep(fields);
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "*100\n" +
                                    "2210\n" +
                                    "1*10\n" +
                                    "1110\n" +
                                    "~~~\n" + 
                                    "\n" + 
                                    "~~~\n" +
                                    "Field #2:\n" +
                                    "**100\n" +
                                    "33200\n" +
                                    "1*100\n" +
                                    "~~~\n" +
                                    "\n";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnEmptyField()
        {
            var mineSweeper = new MineSweeper();
            const string fields = "~~~\n" +
                                  "00\n" +
                                  "~~~";
            var actual = mineSweeper.Sweep(fields);
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "~~~\n" +
                                    "\n";
            Assert.AreEqual(expected, actual);
        }
    }
}
