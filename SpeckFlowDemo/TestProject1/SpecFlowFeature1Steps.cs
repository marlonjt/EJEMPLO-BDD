using System;
using TechTalk.SpecFlow;
using Calculadora;

namespace TestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        public Calculadora miCalculadora = new Calculadora();

        [Given(@"I have entered (.*) into the calculator")]
        [Obsolete]
        public void GivenIHaveEnteredIntoTheCalculator(int numero)
        {
            miCalculadora.operadorA = numero;
           
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        [Obsolete]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int numero2)
        {
            miCalculadora.operadorB = numero2;
        }
        
        [When(@"I press add")]
        [Obsolete]
        public void WhenIPressAdd()
        {
            resultado = miCalculadora.Suma();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        [Obsolete]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(resultado,p0)
        }
    }
}
