using System.Reflection;
using MineSweeperKata;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MineSweeperSpecs
{
    [Binding]
    public class MineSweeperMultipleFieldsSteps
    {
        private string _multipleFields;
        private string _result;
        private readonly MineSweeper _mineSweeper = new MineSweeper();

        [Given(@"I have a two by three and a three by five fields")]
        public void GivenIHaveATwoByThreeAndAThreeByFiveFields()
        {
            _multipleFields = "~~~\n" +
                              "23\n" +
                              "*..\n" +
                              "..*\n" +
                              "~~~\n" +
                              "\n" +
                              "~~~\n" +
                              "35\n" +
                              "**...\n" +
                              ".....\n" +
                              ".*...\n" +
                              "~~~";
        }

        [When(@"the MineSweeper sweep multiple fields")]
        public void WhenTheMineSweeperSweepMultipleFields()
        {
            _result = _mineSweeper.Sweep(_multipleFields);
        }

        [Then(@"the result should be two fields that each square would display the number of surrounding bombs")]
        public void ThenTheResultShouldBeTwoFieldsThatEachSquareWouldDisplayTheNumberOfSurroundingBombs()
        {
            const string expected = "~~~\n" +
                                    "Field #1:\n" +
                                    "*21\n" +
                                    "12*\n" +
                                    "~~~\n" +
                                    "\n" +
                                    "~~~\n" +
                                    "Field #2:\n" +
                                    "**100\n" +
                                    "33200\n" +
                                    "1*100\n" +
                                    "~~~\n" +
                                    "\n";

            Assert.AreEqual(expected, _result);
        }
    }
}