namespace RedStar.TddCourse.Styles.Classicist
{
    public class CarPriceCalculator
    {
        private readonly WheelPriceCalculator _wheelPriceCalculator;
        private readonly IExternalPriceService _externalPriceService;

        public CarPriceCalculator(WheelPriceCalculator wheelPriceCalculator, IExternalPriceService externalPriceService)
        {
            _wheelPriceCalculator = wheelPriceCalculator;
            _externalPriceService = externalPriceService;
        }

        public double CalculatePrice(Car car)
        {
            var basePrice = _externalPriceService.GetBasePrice(car);
            var wheelPrice = _wheelPriceCalculator.GetWheelPrice(car);

            return basePrice + wheelPrice;
        }
    }
}