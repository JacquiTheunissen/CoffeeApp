namespace CoffeeApp.Services
{
    public static class MilkService
    {
        public static int AvailableMilk { get; set; }

        public static int MilkUsed { get; set; }

        public static void SetRemainingMilk()
        {
            AvailableMilk = AvailableMilk - MilkUsed;
        }
    }
}
