using System;
using RedStar.TddCourse.Discounts;

namespace RedStar.TddCourse.Tests.Reuse.Builders
{
    public class CustomerBuilder
    {
        private readonly Customer _customer;

        public CustomerBuilder()
        {
            _customer = new Customer();
        }

        public CustomerBuilder AsEmployee()
        {
            _customer.IsEmployee = true;
            return this;
        }

        public CustomerBuilder AsGoldMember()
        {
            _customer.IsGoldMember = true;
            return this;
        }

        public CustomerBuilder WithBirthDate(DateTime birthDate)
        {
            _customer.Birthdate = birthDate;
            return this;
        }

        public Customer Build()
        {
            return _customer;
        }
    }
}