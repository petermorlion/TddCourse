using System;
using FluentAssertions;
using RedStar.TddCourse.TestInfrastructure;
using Xunit;

namespace RedStar.TddCourse.Tests.Reuse.Builders
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void CalculateDiscount_ForGoldMemberEmployeeOnBirthday_ShouldReturnForty()
        {
            var customer = new CustomerBuilder()
                .AsEmployee()
                .AsGoldMember()
                .WithBirthDate(DateTime.UtcNow)
                .Build();

            var discountCalculator = new DiscountCalculatorFactory().Create();

            var discount = discountCalculator.CalculateDiscount(customer);

            discount.Should().Be(40);
        }
    }
}