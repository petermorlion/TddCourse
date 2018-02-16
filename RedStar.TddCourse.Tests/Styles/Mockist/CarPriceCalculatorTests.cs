using FluentAssertions;
using Moq;
using RedStar.TddCourse.Styles;
using RedStar.TddCourse.Styles.Mockist;
using Xunit;

namespace RedStar.TddCourse.Tests.Styles.Mockist
{
    public class CarPriceCalculatorTests
    {
        [Fact]
        public void Calculate_ForCarWithWheels_ShouldReturnSumOfPrices()
        {
            var car = new Car { Wheels = 0 };

            var externalPriceServiceMock = new Mock<IExternalPriceService>();
            externalPriceServiceMock.Setup(x => x.GetBasePrice(car)).Returns(20000);

            var wheelPriceCalculatorMock = new Mock<IWheelPriceCalculator>();
            wheelPriceCalculatorMock.Setup(x => x.GetWheelPrice(car)).Returns(3000);

            var calculator = new CarPriceCalculator(wheelPriceCalculatorMock.Object, externalPriceServiceMock.Object);

            var price = calculator.CalculatePrice(car);

            price.Should().Be(23000);
        }
    }
}