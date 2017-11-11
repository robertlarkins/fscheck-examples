using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class VerboseExample
    {
        /// <summary>
        /// When Verbose is set to true, all the generated arguments are displayed in the Output window
        /// with the test result.
        /// </summary>
        /// <remarks>
        /// Output is a link in the Test Explorer with each test that can be clicked on to give more details.
        /// </remarks>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        [Property(Verbose = true)]
        public void VerboseIsTrue_DisplayAllGeneratedArguments(int one, double two, string three)
        {
            one.Should().Be(one);
        }

        /// <summary>
        /// When Verbose is set to false, only a standard message is displayed in the Output window.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        [Property(Verbose = false)]
        public void VerboseIsFalse_DisplayStandardOutput(int one, double two, string three)
        {
            one.Should().Be(one);
        }

        /// <summary>
        /// The default value for Verbose is false.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        [Property]
        public void VerboseIsDefault_DisplayStandardOutput(int one, double two, string three)
        {
            one.Should().Be(one);
        }
    }
}
