using System;

namespace RedStar.TddCourse.Discounts
{
    public class DiscountCalculator1 : IDiscountCalculator
    {
        public double CalculateDiscount(Customer customer)
        {
            if (!customer.IsGoldMember && customer.Birthdate.Date == DateTime.UtcNow.Date)
            {
                return 40;
            }

            if (customer.IsGoldMember)
            {
                if (DateTime.UtcNow.Year - customer.Birthdate.Year > 40)
                {
                    return 30;
                }

                if (customer.IsEmployee)
                {
                    if (DateTime.UtcNow.Year - customer.Birthdate.Year > 40)
                    {
                        return 20;
                    }
                    else
                    {
                        return 15;
                    }
                }

                if (customer.Birthdate.Date == DateTime.UtcNow.Date)
                {
                    return 40;
                }
            }

            return 0;
        }
    }
}
