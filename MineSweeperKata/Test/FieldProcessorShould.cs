using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class FieldProcessorShould
    {
        [Test]
        public void ReturnFieldInfo()
        {
            var fieldProcessor = new FieldProcessor();
            var fields = "~~~\n" +
                         "44 \n" +
                         "*... \n" +
                         ".... \n" +
                         ".*.. \n" +
                         "....\n" +
                         "~~~";
            var actual = fieldProcessor.Process(fields);
            var expected = new Field()
            {
                NoOfRows = 4,
                NoOfColumns = 4,
                Value = "*..." +
                        "...." +
                        ".*.." +
                        "...."
        };
            Assert.AreEqual(expected.NoOfRows, actual.NoOfRows);
            Assert.AreEqual(expected.NoOfColumns, actual.NoOfColumns);
            Assert.AreEqual(expected.Value, actual.Value);
        }
    }
}