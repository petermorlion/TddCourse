using System;
using FluentAssertions;
using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;
using TechTalk.SpecFlow;

namespace RedStar.TddCourse.Specs
{
    [Binding]
    public class DiscountCalculationSteps
    {
        [Given(@"A customer")]
        public void GivenACustomer()
        {
            ScenarioContext.Current["Customer"] = new Customer();
        }
        
        [Given(@"it is his birthday")]
        public void GivenItIsHisBirthday()
        {
            ((Customer) ScenarioContext.Current["Customer"]).Birthdate = DateTime.UtcNow;
        }
        
        [When(@"I calculate the discount")]
        public void WhenICalculateTheDiscount()
        {
            var discountCalculator = new DiscountCalculatorFactory().Create();
            var customer = ((Customer) ScenarioContext.Current["Customer"]);
            ScenarioContext.Current["Discount"] = discountCalculator.CalculateDiscount(customer);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedDiscount)
        {
            ((double) ScenarioContext.Current["Discount"]).Should().Be(expectedDiscount);
        }
    }
}
