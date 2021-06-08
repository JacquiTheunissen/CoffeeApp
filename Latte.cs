using CoffeeApp.Services;
using System;

namespace CoffeeApp
{
    public class Latte : IDrink
    {
        public void MakeDrink()
        {
            var sufficientBeans = BeanService.HasSufficientAvailableBeans();

            if (sufficientBeans)
            {
                BeanService.SetRemainingBeans();
                MilkService.MilkUsed = 2;
                MilkService.SetRemainingMilk();

                Console.WriteLine($"{nameof(Latte)} ready");
            }
        }
    }
}
