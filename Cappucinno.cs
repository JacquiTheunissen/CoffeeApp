using CoffeeApp.Services;
using System;

namespace CoffeeApp
{
    public class Cappucinno : IDrink
    {
        public void MakeDrink()
        {
            var sufficientBeans = BeanService.HasSufficientAvailableBeans();

            if (sufficientBeans)
            {
                Console.WriteLine("How many sugars?");

                var sugars = Console.ReadLine();

                if (!String.IsNullOrEmpty(sugars) && Convert.ToInt16(sugars) >= 0)
                {
                    BeanService.SetRemainingBeans();
                    MilkService.MilkUsed = 3;
                    MilkService.SetRemainingMilk();

                    Console.WriteLine("Cappucinno ready");
                }
                else
                {
                    Console.WriteLine("Please enter amount of sugar needed");
                }
            }
        }
    }
}
