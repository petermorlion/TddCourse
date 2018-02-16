namespace RedStar.TddCourse.Styles.Mockist
{
    public class ExternalPriceService : IExternalPriceService
    {
        public double GetBasePrice(Car car)
        {
            return 25000;
        }
    }
}