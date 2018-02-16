namespace RedStar.TddCourse.Styles.Mockist
{
    public class WheelPriceCalculator : IWheelPriceCalculator
    {
        public double GetWheelPrice(Car car)
        {
            return car.Wheels * 1000;
        }
    }
}