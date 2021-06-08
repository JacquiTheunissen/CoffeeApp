using CoffeeApp.Services;
using System;

namespace CoffeeApp
{
    public class Order
    {
        public void ProcessOrder()
        {
            BeanService.AvailableBeans = 25;
            BeanService.BeansUsed = 5;
            MilkService.AvailableMilk = 20;

            var menu = new Menu();

            while (true)
            {
                switch (menu.GetOption())
                {
                    case "1":
                        var coffee = new Coffee();
                        coffee.MakeDrink();
                        break;
                    case "2":
                        var cappucinno = new Cappucinno();
                        cappucinno.MakeDrink();
                        break;
                    case "3":
                        var latte = new Latte();
                        latte.MakeDrink();
                        break;
                    case "off":
                        CancelOrder();
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        public void CancelOrder()
        {
            Environment.Exit(0);
        }
    }
}
