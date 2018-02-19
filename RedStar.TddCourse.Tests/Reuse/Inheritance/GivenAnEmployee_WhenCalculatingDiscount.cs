namespace RedStar.TddCourse.Tests.Reuse.Inheritance
{
    public abstract class GivenAnEmployee_WhenCalculatingDiscount : GivenACustomer_WhenCalculatingDiscount
    {
        public override void Arrange()
        {
            base.Arrange();
            Customer.IsEmployee = true;
        }
    }
}