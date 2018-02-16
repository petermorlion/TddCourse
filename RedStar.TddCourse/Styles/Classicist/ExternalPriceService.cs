namespace RedStar.TddCourse.Styles.Classicist
{
    public class ExternalPriceService : IExternalPriceService
    {
        public double GetBasePrice(Car car)
        {
            return 25000;
        }
    }
}