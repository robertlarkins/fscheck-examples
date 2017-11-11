using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;
using Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    /// <summary>
    /// This link (https://github.com/fscheck/FsCheck/issues/373) gives more insight into how FsCheck operates
    /// 
    /// The generated int value one is displayed in the debug output window only five times
    /// (for the tests that produce a debug output)
    /// </summary>
    public class MaxTestExamples
    {
        /// <summary>
        /// This approach is usable and equivalent to using an assert in the test, 
        /// but it returns an FsCheck property instead. While equivalent, it isn't
        /// as easy to use as Assert, or passing in the generated value.
        /// All the work has to be done as a single Fluent statement inside the
        /// Prop.ForAll
        /// </summary>
        /// <returns></returns>
        [Property(MaxTest = 5)]
        public Property MaxTestParam_PropForAll_ReturnProperty()
        {
            return Prop.ForAll<int>(one => one == one);
        }

        /// <summary>
        /// This approach is usable and equivalent to using an assert in the test, 
        /// but it returns an FsCheck property instead. While equivalent, it isn't
        /// quite as simple as using an Assert.
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        [Property(MaxTest = 5)]
        public Property MaxTestParam_InputVariable_ReturnProperty(int one)
        {
            System.Diagnostics.Debug.WriteLine($"Example 1, Value one = {one}");

            var result = one == one;

            return result.ToProperty();
        }

        /// <summary>
        /// This approach is recommened if not using the MaxFail param,
        /// and using fluent assertions
        /// </summary>
        /// <param name="one"></param>
        [Property(MaxTest = 5)]
        public void MaxTestParam_FluentAssertions(int one)
        {
            System.Diagnostics.Debug.WriteLine($"Example 2, Value one = {one}");

            one.Should().Be(one);
        }

        /// <summary>
        /// This approach is recommened if not using the MaxFail param,
        /// and using xunit for asserting
        /// </summary>
        /// <param name="one"></param>
        [Property(MaxTest = 5)]
        public void MaxTestParam_XunitAssert(int one)
        {
            System.Diagnostics.Debug.WriteLine($"Example 3, Value one = {one}");

            Assert.Equal(one, one);
        }

        /// <summary>
        /// This approach of only returning a bool works,
        /// but it doesn't give much feedback if the property fails.
        /// </summary>
        /// <param name="one"></param>
        [Property(MaxTest = 5)]
        public bool MaxTestParam_ReturnBool(int one)
        {
            System.Diagnostics.Debug.WriteLine($"Example 4, Value one = {one}");

            return one == one;
        }
    }
}
