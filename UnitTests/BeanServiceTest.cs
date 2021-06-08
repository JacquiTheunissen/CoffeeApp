using CoffeeApp.Services;
using Xunit;

namespace UnitTests
{
    public class BeanServiceTest
    {
        [Fact]
        public void SufficientAvailableBeans_ShouldBeTrue()
        {
            BeanService.AvailableBeans = 25;
            BeanService.BeansUsed = 5;

            var isSufficient = BeanService.HasSufficientAvailableBeans();

            Assert.True(isSufficient);
        }

        [Fact]
        public void SufficientAvailableBeans_ShouldBeFalse()
        {
            BeanService.AvailableBeans = 0;
            BeanService.BeansUsed = 5;

            var isSufficient = BeanService.HasSufficientAvailableBeans();

            Assert.False(isSufficient);
        }

        [Fact]
        public void SetRemainingBeans_ShouldBeEqual()
        {
            BeanService.AvailableBeans = 25;
            BeanService.BeansUsed = 5;
            var expectedOutput = 20;

            BeanService.SetRemainingBeans();

            Assert.Equal(BeanService.AvailableBeans, expectedOutput);
        }
    }
}
