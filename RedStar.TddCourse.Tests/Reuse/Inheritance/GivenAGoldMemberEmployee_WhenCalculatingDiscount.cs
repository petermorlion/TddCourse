namespace RedStar.TddCourse.Tests.Reuse.Inheritance
{
    public abstract class GivenAGoldMemberEmployee_WhenCalculatingDiscount : GivenACustomer_WhenCalculatingDiscount
    {
        public override void Arrange()
        {
            base.Arrange();
            Customer.IsGoldMember = true;
            Customer.IsEmployee = true;
        }
    }
}