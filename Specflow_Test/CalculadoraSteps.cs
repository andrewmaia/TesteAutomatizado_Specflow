using System;
using TechTalk.SpecFlow;
using CalculadoraProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Specflow_Test
{
    [Binding]
    public class CalculadoraSteps
    {
        private int result;
        Calculadora calculadora = new Calculadora();
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculadora.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculadora.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculadora.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
