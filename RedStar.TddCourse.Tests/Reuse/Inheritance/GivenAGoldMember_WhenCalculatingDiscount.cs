namespace RedStar.TddCourse.Tests.Reuse.Inheritance
{
    public abstract class GivenAGoldMember_WhenCalculatingDiscount : GivenACustomer_WhenCalculatingDiscount
    {
        public override void Arrange()
        {
            base.Arrange();
            Customer.IsGoldMember = true;
        }
    }
}