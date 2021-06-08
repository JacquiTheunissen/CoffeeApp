using System;

namespace CoffeeApp.Services
{
    public static class BeanService
    {
        public static int AvailableBeans { get; set; }

        public static int BeansUsed { get; set; }

        public static bool HasSufficientAvailableBeans()
        {
            if (AvailableBeans >= BeansUsed)
            {
                if (AvailableBeans == BeansUsed)
                {
                    Console.WriteLine("!!!! Warning: bean level running low !!!!");
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Insufficient amount of beans available");
                return false;
            }
            return true;
        }

        public static void SetRemainingBeans()
        {
            AvailableBeans = AvailableBeans - BeansUsed;
        }
    }
}
