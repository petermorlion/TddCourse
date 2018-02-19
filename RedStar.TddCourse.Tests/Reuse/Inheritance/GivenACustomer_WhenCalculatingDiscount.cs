using RedStar.TddCourse.Discounts;
using RedStar.TddCourse.TestInfrastructure;

namespace RedStar.TddCourse.Tests.Reuse.Inheritance
{
    public abstract class GivenACustomer_WhenCalculatingDiscount : GivenWhenThen
    {
        protected Customer Customer { get; private set; }

        protected double Result { get; set; }

        public override void Arrange()
        {
            Customer = new Customer();
        }

        public override void Act()
        {
            Result = new DiscountCalculatorFactory().Create().CalculateDiscount(Customer);
        }
    }
}