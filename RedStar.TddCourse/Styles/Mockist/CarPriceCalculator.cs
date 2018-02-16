namespace RedStar.TddCourse.Styles.Mockist
{
    public class CarPriceCalculator
    {
        private readonly IWheelPriceCalculator _wheelPriceCalculator;
        private readonly IExternalPriceService _externalPriceService;

        public CarPriceCalculator(IWheelPriceCalculator wheelPriceCalculator, IExternalPriceService externalPriceService)
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