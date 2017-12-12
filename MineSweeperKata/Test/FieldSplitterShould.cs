using System.Collections.Generic;
using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class FieldSplitterShould
    {
        [Test]
        public void ReturnSplitFieldFromString()
        {
            var fieldSplitter = new FieldSplitter();
            var field = "~~~\n" +
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
            var actual = fieldSplitter.Split(field);
            var expected = new List<string>
            {
                "~~~\n" +
                "44\n" +
                "*...\n" +
                "....\n" +
                ".*..\n" +
                "....\n" +
                "~~~",

                "~~~\n" +
                "35\n" +
                "**...\n" +
                ".....\n" +
                ".*...\n" +
                "~~~"
            };
            Assert.AreEqual(expected, actual);
        }
    }
}