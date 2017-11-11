using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class SkipExamples
    {
        /// <summary>
        /// Skip the test, and display the skip reason in the Output of the test result
        /// </summary>
        /// <param name="intParam"></param>
        [Property(Skip = "Reason for skipping test.")]
        public void SkipTest_ReasonString_TestIsSkipped(double doubleParam)
        {
            // Arrange
            // Act
            object boxedBool = doubleParam;

            // Assert
            boxedBool.Should().BeOfType<double>();
        }

        /// <summary>
        /// The test still runs as the skip reason is an empty string
        /// </summary>
        /// <param name="intParam"></param>
        [Property(Skip = "")]
        public void SkipTest_EmptyString_TestStillRuns(double doubleParam)
        {
            // Arrange
            // Act
            object boxedBool = doubleParam;

            // Assert
            boxedBool.Should().BeOfType<double>();
        }

        /// <summary>
        /// Skip the test, and display the newline whitespace in the Output of the test result
        /// </summary>
        /// <param name="intParam"></param>
        [Property(Skip = "\n")]
        public void SkipTest_Newline_TestIsSkipped(double doubleParam)
        {
            // Arrange
            // Act
            object boxedBool = doubleParam;

            // Assert
            boxedBool.Should().BeOfType<double>();
        }

        /// <summary>
        /// The test still runs as the skip reason is null
        /// </summary>
        /// <param name="intParam"></param>
        [Property(Skip = null)]
        public void SkipTest_NullValue_TestStillRuns(double doubleParam)
        {
            // Arrange
            // Act
            object boxedBool = doubleParam;

            // Assert
            boxedBool.Should().BeOfType<double>();
        }
    }
}
