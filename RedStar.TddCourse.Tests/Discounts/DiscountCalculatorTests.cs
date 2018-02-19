using System;
using FluentAssertions;
using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;
using Xunit;

namespace RedStar.TddCourse.Tests.Discounts
{
    public class DiscountCalculatorTests
    {
        [Fact]
        public void CalculateDiscount_ForGoldMemberOnBirthday_ShouldReturn40()
        {
            var customer = new Customer
            {
                Birthdate = DateTime.UtcNow,
                IsGoldMember = true
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(40);
        }

        [Fact]
        public void CalculateDiscount_ForNonGoldMemberOnBirthday_ShouldReturn40()
        {
            var customer = new Customer
            {
                Birthdate = DateTime.UtcNow,
                IsGoldMember = false
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(40);
        }

        [Fact]
        public void CalculateDiscount_ForGoldMemberOlderThan40_ShouldReturn30()
        {
            var customer = new Customer
            {
                Birthdate = new DateTime(1940, 1, 1),
                IsGoldMember = true
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(30);
        }

        [Fact]
        public void CalculateDiscount_ForGoldMemberOlderThan40AndIsEmployee_ShouldReturn30()
        {
            var customer = new Customer
            {
                Birthdate = new DateTime(1940, 1, 1),
                IsGoldMember = true,
                IsEmployee = true
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(30);
        }

        [Fact]
        public void CalculateDiscount_ForGoldMemberYoungerThan40AndIsEmployee_ShouldReturn15()
        {
            var customer = new Customer
            {
                Birthdate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(10 * 365)),
                IsGoldMember = true,
                IsEmployee = true
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(15);
        }

        [Fact]
        public void CalculateDiscount_ForNonGoldMemberNotOnBirthday_ShouldReturn0()
        {
            var customer = new Customer
            {
                Birthdate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(10 * 365)),
                IsGoldMember = false,
                IsEmployee = false
            };

            var calculator = new DiscountCalculatorFactory().Create();

            var discount = calculator.CalculateDiscount(customer);

            discount.Should().Be(0);
        }
    }
}
