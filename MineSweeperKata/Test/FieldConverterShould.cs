using MineSweeperKata.DTO;
using NUnit.Framework;

namespace MineSweeperKata.Test
{
    [TestFixture]
    public class FieldConverterShould
    {
        [Test]
        public void ReturnFieldInfo()
        {
            var fieldConverter = new FieldConverter();
            var fields = "~~~\n" +
                         "44\n" +
                         "*...\n" +
                         "....\n" +
                         ".*..\n" +
                         "....\n" +
                         "~~~\n";
            var actual = fieldConverter.ConvertFrom(fields);
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