using CoffeeApp.Services;
using Xunit;

namespace UnitTests
{
    public class MilkServiceTest
    {
        [Fact]
        public void SetRemainingBeans_ShouldBeEqual()
        {
            MilkService.AvailableMilk = 20;
            MilkService.MilkUsed = 3;
            var expectedOutput = 17;

            MilkService.SetRemainingMilk();

            Assert.Equal(MilkService.AvailableMilk, expectedOutput);
        }

        [Fact]
        public void SetRemainingBeans_ShouldNotBeEqual()
        {
            MilkService.AvailableMilk = 15;
            MilkService.MilkUsed = 1;
            var expectedOutput = 12;

            MilkService.SetRemainingMilk();

            Assert.NotEqual(MilkService.AvailableMilk, expectedOutput);
        }
    }
}
