using System;
using RedStar.TddCourse.Discounts;

namespace RedStar.TddCourse.TestInfrastructure
{
    public class DiscountCalculatorFactory
    {
        public IDiscountCalculator Create()
        {
            //return new DiscountCalculator1();

            return new DiscountCalculator2();
        }
    }
}
