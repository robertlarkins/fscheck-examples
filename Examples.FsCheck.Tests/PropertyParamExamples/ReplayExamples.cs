using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class ReplayExamples
    {
        /// <summary>
        /// The Replay values of a test are displayed in the Test Explorer window when a failed Property test has finished running.
        /// The resulting message will look something like this:
        /// Message: FsCheck.Xunit.PropertyFailedException : Falsifiable, after 1 test(5 shrinks) (StdGen (1715301281,296321667))
        /// The StdGen values are what go in Replay param for rerunning with the same generated values.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        [Property(MaxTest = 5)]
        public void GenerateReplayValuesInTestExplorer(int one, int two)
        {
            System.Diagnostics.Debug.WriteLine($"{one},{two}");

            one.Should().Be(two);
        }

        /// <summary>
        /// Run this test 5 times only. Replay specifies the random seed to use for number generation
        /// This always produces the same numbers:
        /// 7,4
        /// 8,12.7222222222222
        /// 11,-21.5714285714286
        /// -26,-inf
        /// 48,inf
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        [Property(MaxTest = 5, Replay = "302083116,296316033")]
        public void DisplayPropertyInputs(int one, double two)
        {

            //one.Should().Be((int)two);

            System.Diagnostics.Debug.WriteLine($"{one},{two}");
        }
    }
}
