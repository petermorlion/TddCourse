using System;
using FluentAssertions;
using NUnit.Framework;
using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;

namespace RedStar.TddCourse.Naming.BDD.DiscountCalculatorTests
{
    [TestFixture]
    public class GivenCustomerOnBirthday_WhenCalculatingDiscount : GivenWhenThen
    {
        private IDiscountCalculator _discountCalculator;
        private Customer _customer;
        private double _result;

        public override void Arrange()
        {
            _customer = new Customer {Birthdate = DateTime.UtcNow};
            _discountCalculator = new DiscountCalculatorFactory().Create();
        }

        public override void Act()
        {
            _result = _discountCalculator.CalculateDiscount(_customer);
        }

        [Test]
        public void ThenDiscountShouldBeForty()
        {
            _result.Should().Be(40);
        }
    }
}