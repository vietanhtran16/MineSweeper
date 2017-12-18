using MineSweeperKata;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MineSweeperSpecs
{
    [Binding]
    public class MineSweeperSteps
    {
        private string _emptyField;
        private string _result;
        private readonly MineSweeper _mineSweeper = new MineSweeper();

        [Given(@"I have a zero by zero \(empty\) field")]
        public void GivenIHaveAZeroByZeroEmptyField()
        {
            _emptyField = "~~~\n" +
                          "00\n" +
                          "~~~";
        }

        [When(@"the MineSweeper sweep the empty field")]
        public void WhenTheMineSweeperSweepTheEmptyField()
        {
            _result = _mineSweeper.Sweep(_emptyField);
        }

        [Then(@"the result should only return count name of field")]
        public void ThenTheResultShouldOnlyReturnCountNameOfField()
        {
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "~~~\n" +
                                    "\n";
            Assert.AreEqual(expected, _result);
        }
    }
}