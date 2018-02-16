namespace RedStar.TddCourse.Styles.Classicist
{
    public class WheelPriceCalculator
    {
        public double GetWheelPrice(Car car)
        {
            return car.Wheels * 1000;
        }
    }
}