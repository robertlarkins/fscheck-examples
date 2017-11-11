using FluentAssertions;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class DisplayNameExamples
    {
        /// <summary>
        /// In the test explorer, display the name given in DisplayName,
        /// instead of the fully qualified test name.
        /// </summary>
        /// <param name="boolParam"></param>
        [Property(DisplayName = "A new test name")]
        public void DisplayName_NameString_NewDisplayName(bool boolParam)
        {
            // Arrange
            // Act
            object boxedBool = boolParam;

            // Assert
            boxedBool.Should().BeOfType<bool>();
        }

        /// <summary>
        /// Null is the default value for DisplayName,
        /// so the fully qualified test name will display
        /// </summary>
        /// <param name="boolParam"></param>
        [Property(DisplayName = null)]
        public void DisplayName_NullValue_DisplayStandardTestName(bool boolParam)
        {
            // Arrange
            // Act
            object boxedBool = boolParam;

            // Assert
            boxedBool.Should().BeOfType<bool>();
        }

        /// <summary>
        /// Empty string DisplayName value causes the
        /// fully qualified test name to display
        /// </summary>
        /// <param name="boolParam"></param>
        [Property(DisplayName = "")]
        public void DisplayName_EmptyString_DisplayStandardTestName(bool boolParam)
        {
            // Arrange
            // Act
            object boxedBool = boolParam;

            // Assert
            boxedBool.Should().BeOfType<bool>();
        }

        /// <summary>
        /// Newline value for DisplayName is treated as a string literal and is displayed as such.
        /// </summary>
        /// <param name="boolParam"></param>
        [Property(DisplayName = "\n")]
        public void DisplayName_Newline_NewDisplayName(bool boolParam)
        {
            // Arrange
            // Act
            object boxedBool = boolParam;

            // Assert
            boxedBool.Should().BeOfType<bool>();
        }
    }
}
