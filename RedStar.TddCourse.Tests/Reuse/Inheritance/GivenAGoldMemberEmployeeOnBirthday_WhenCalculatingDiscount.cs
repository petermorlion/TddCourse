using System;
using FluentAssertions;
using NUnit.Framework;

namespace RedStar.TddCourse.Tests.Reuse.Inheritance
{
    [TestFixture]
    public class GivenAGoldMemberEmployeeOnBirthday_WhenCalculatingDiscount : GivenAGoldMemberEmployee_WhenCalculatingDiscount
    {
        public override void Arrange()
        {
            base.Arrange();
            Customer.Birthdate = DateTime.UtcNow;
        }

        [Test]
        public void ShouldReturnForty()
        {
            Customer.IsGoldMember.Should().BeTrue();
            Customer.IsEmployee.Should().BeTrue();
            Customer.Birthdate.Date.Should().Be(DateTime.UtcNow.Date);
            Result.Should().Be(40);
        }
    }
}