using NUnit.Framework;

namespace RedStar.TddCourse.TestInfrastructure
{
    [TestFixture]
    public abstract class GivenWhenThen
    {
        [SetUp]
        public void SetUp()
        {
            Arrange();
            Act();
        }

        public abstract void Arrange();
        public abstract void Act();
    }
}