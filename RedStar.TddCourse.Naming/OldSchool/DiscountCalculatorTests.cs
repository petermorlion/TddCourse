using System;
using NUnit.Framework;
using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;

namespace RedStar.TddCourse.Naming.OldSchool
{
    [TestFixture]
    public class DiscountCalculatorTests
    {
        [Test]
        public void TestCalculateDiscountOnBirthday()
        {
            var customer = new Customer {Birthdate = DateTime.UtcNow};
            var discountCalculator = new DiscountCalculatorFactory().Create();

            var result = discountCalculator.CalculateDiscount(customer);

            Assert.AreEqual(40, result);
        }

        [Test]
        public void TestCalculateDiscountForGoldMemberOlderThanFortyYears() { }

        [Test]
        public void TestCalculateDiscountForGoldMemberEmployeeYoungerThanFortyYears() { }
    }
}