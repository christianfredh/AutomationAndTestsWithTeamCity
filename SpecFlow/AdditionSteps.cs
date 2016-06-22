using System;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlow
{
    [Binding]
    public class AdditionSteps
    {
        private Calculator _calculator;

        private int _result;

        [Given(@"a calculator")]
        public void GivenACalculator()
        {
            _calculator = new Calculator();
        }
        
        [When(@"I have add (.*) and (.*) together into the calculator")]
        public void WhenIHaveAddAndTogetherIntoTheCalculator(int a, int b)
        {
            _result = _calculator.Add(a, b);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}
