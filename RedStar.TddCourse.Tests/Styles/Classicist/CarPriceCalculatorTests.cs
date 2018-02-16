using FluentAssertions;
using Moq;
using RedStar.TddCourse.Styles;
using RedStar.TddCourse.Styles.Classicist;
using Xunit;

namespace RedStar.TddCourse.Tests.Styles.Classicist
{
    public class CarPriceCalculatorTests
    {
        [Fact]
        public void Calculate_ForCarWithoutWheels_ShouldReturnBasePrice()
        {
            var car = new Car {Wheels = 0};

            var externalPriceServiceMock = new Mock<IExternalPriceService>();
            externalPriceServiceMock.Setup(x => x.GetBasePrice(car)).Returns(20000);

            var calculator = new CarPriceCalculator(new WheelPriceCalculator(), externalPriceServiceMock.Object);

            var price = calculator.CalculatePrice(car);

            price.Should().Be(20000);
        }

        [Fact]
        public void Calculate_ForCarWithWheels_ShouldReturnSumOfPrices()
        {
            var car = new Car { Wheels = 4 };

            var externalPriceServiceMock = new Mock<IExternalPriceService>();
            externalPriceServiceMock.Setup(x => x.GetBasePrice(car)).Returns(20000);

            var calculator = new CarPriceCalculator(new WheelPriceCalculator(), externalPriceServiceMock.Object);

            var price = calculator.CalculatePrice(car);

            price.Should().Be(24000);
        }
    }
}