using MineSweeperKata;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MineSweeperSpecs
{
    [Binding]
    public class MineSweeperSteps
    {
        private string _rawField;
        private string _result;
        private readonly MineSweeper _mineSweeper = new MineSweeper();
        [Given(@"I have a four by four field")]
        public void GivenIHaveAFourByFourField()
        {
            _rawField = "~~~\n" +
                        "44\n" +
                        "*...\n" +
                        "....\n" +
                        ".*..\n" +
                        "....\n" +
                        "~~~";
        }
        
        [When(@"the MineSweeper sweep the field")]
        public void WhenTheMineSweeperSweepTheField()
        {
            _result = _mineSweeper.Sweep(_rawField);
        }
        
        [Then(@"the result should be a field that each square would display the number of surrounding bombs")]
        public void ThenTheResultShouldBeAFieldThatEachSquareWouldDisplayTheNumberOfSurroundingBombs()
        {
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "*100\n" +
                                    "2210\n" +
                                    "1*10\n" +
                                    "1110\n" +
                                    "~~~\n" +
                                    "\n";
            Assert.AreEqual(expected, _result);
        }
    }
}
