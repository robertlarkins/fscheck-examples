using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class StartSizeAndEndSizeExamples
    {
        /// <summary>
        /// https://fsharpforfunandprofit.com/posts/property-based-testing/
        /// Generators start with small numbers and gradually increase them.
        /// This is controlled by the StartSize and EndSize settings.
        /// By default, StartSize is 1 and EndSize is 100.
        /// So at the end of the test, the "size" parameter to the generator will be 100.
        /// 
        /// Defaults: StartSize = 1, EndSize = 100
        /// </summary>
        /// <param name="one"></param>
        [Property(StartSize = 500, EndSize = 10000)]
        public void StartEndTest(int one, double two)
        {
            System.Diagnostics.Debug.WriteLine($"{one},{two}");
            one.Should().Be(one);
        }
    }
}
