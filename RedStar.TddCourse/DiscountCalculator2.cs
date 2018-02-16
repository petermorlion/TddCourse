using System;

namespace RedStar.TddCourse
{
    public class DiscountCalculator2 : IDiscountCalculator
    {
        public double CalculateDiscount(Customer customer)
        {
            if (customer.Birthdate.Date == DateTime.UtcNow.Date)
            {
                return 40;
            }

            if (customer.IsGoldMember && DateTime.UtcNow.Year - customer.Birthdate.Year > 40)
            {
                return 30;
            }

            if (customer.IsGoldMember && DateTime.UtcNow.Year - customer.Birthdate.Year < 40 && customer.IsEmployee)
            {
                return 15;
            }

            return 0;
        }
    }
}
