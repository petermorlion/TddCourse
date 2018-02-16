using System;
using Autofac;
using RedStar.TddCourse.Infrastructure;

namespace RedStar.TddCourse.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<EmailService>().As<IEmailService>();
            containerBuilder.RegisterType<DiscountCalculator2>();

            var container = containerBuilder.Build();

            var discountCalculator = container.Resolve<DiscountCalculator2>();

            Console.WriteLine("Employee: " + discountCalculator.CalculateDiscount(new Customer { IsEmployee = true} ));
            Console.WriteLine("Birthday: " + discountCalculator.CalculateDiscount(new Customer { Birthdate = DateTime.UtcNow } ));
            Console.WriteLine("Old goldmember: " + discountCalculator.CalculateDiscount(new Customer { Birthdate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(50 * 365)), IsGoldMember = true} ));
            Console.WriteLine("Young goldmember: " + discountCalculator.CalculateDiscount(new Customer { Birthdate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(5 * 365)) } ));
            Console.WriteLine("Young goldmember employee: " + discountCalculator.CalculateDiscount(new Customer { Birthdate = DateTime.UtcNow.Subtract(TimeSpan.FromDays(5 * 365)), IsEmployee = true, IsGoldMember = true} ));

            Console.ReadLine();
        }
    }
}
