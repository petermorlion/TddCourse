using System;
using FluentAssertions;
using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;
using Xunit;

namespace RedStar.TddCourse.Naming.xUnit
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void CalculateDiscount_ForCustomerOnBirthday_ShouldReturnForty()
        {
            var customer = new Customer { Birthdate = DateTime.UtcNow };
            var discountCalculator = new DiscountCalculatorFactory().Create();

            var result = discountCalculator.CalculateDiscount(customer);

            result.Should().Be(40);
        }
    }
}