using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class QuietOnSuccess
    {
        /// <summary>
        /// The QuietOnSuccess parameter doesn't appear to do anything for the xunit.net fscheck combination.
        /// It is used for other testing plugins/extensions such as TestDriven.net
        /// </summary>
        /// <param name="one"></param>
        [Property(QuietOnSuccess = true)]
        public void QuietTest(int one)
        {
            one.Should().Be(one);
        }

    }
}
