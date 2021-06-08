using CoffeeApp.Services;
using System;

namespace CoffeeApp
{
    public class Coffee : IDrink
    {
        public void MakeDrink()
        {
            MilkService.MilkUsed = 0;

            var sufficientBeans = BeanService.HasSufficientAvailableBeans();

            if (sufficientBeans)
            {
                Console.WriteLine("Do you want milk? Y/N");

                if (Console.ReadLine().ToLower() == "y")
                {
                    MilkService.MilkUsed = 1;
                }

                BeanService.SetRemainingBeans();
                MilkService.SetRemainingMilk();

                Console.WriteLine($"{nameof(Coffee)} ready");
            }
        }
    }
}
