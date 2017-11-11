using FsCheck.Xunit;
using System;
using Xunit;
using System.Linq;
using FluentAssertions;
using FsCheck;

namespace Examples.FsCheck.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var intArray = new[] { 1, 2, 3 };
            var expected = 3;

            // Act
            var result = intArray.Max();

            // Assert
            result.Should().Be(expected);

        }

        [Fact]
        public void DumbTest()
        {
            Assert.True(false);
        }

        [Fact]
        public void PropertyFailedTests()
        {
            // Arrange
            var ns = new int[0];

            // Act
            var max = ns.Max();

            // Assert

        }

        /// <summary>
        /// The FsCheck Property attribute inputs
        /// </summary>
        /// <param name="Arbitrary">
        /// The Arbitrary instances to use for this test method. The Arbitrary instances
        /// are merged in back to front order i.e. instances for the same generated type
        /// at the front of the array will override those at the back.
        /// </param>
        /// <param name="DisplayName">
        /// Gets the name of the test to be used when the test is skipped.
        /// Defaults to null, which will cause the fully qualified test name to be used.
        /// </param>
        /// <param name="EndSize">
        /// The size to use for the last test, when all the tests are passing. The size increases linearly between Start- and EndSize.
        /// </param>
        /// <param name="MaxFail">
        /// The maximum number of tests where values are rejected, e.g. as the result of ==>
        /// ==> is the disregard operator in F#
        /// 
        /// The maximum number of candidate values that FsCheck will try to generate to achieve the MaxTest value.
        /// As different values can be thrown away
        /// The default appears to be 1000 from different sources (need to verify)
        /// 
        /// </param>
        /// <param name="MaxTest">
        /// The maximum number of tests that are run.
        /// </param>
        /// <param name="QuietOnSuccess">
        /// If set, suppresses the output from the test if the test is successful. This can be useful when running tests
        /// with TestDriven.net, because TestDriven.net pops up the Output window in Visual Studio if a test fails; thus,
        /// when conditioned to that behaviour, it's always a bit jarring to receive output from passing tests.
        /// The default is false, which means that FsCheck will also output test results on success, but if set to true,
        /// FsCheck will suppress output in the case of a passing test. This setting doesn't affect the behaviour in case of
        /// test failures.
        /// </param>
        /// <param name="Replay">
        /// If set, the seed to use to start testing. Allows reproduction of previous runs.
        /// You can just paste the tuple from the output window, e.g. 12344,12312 or (123,123).
        /// </param>
        /// <param name="Skip">
        /// Marks the test so that it will not be run, and gets or sets the skip reason
        /// </param>
        /// <param name="StartSize">
        /// The size to use for the first test.
        /// </param>
        /// <param name="Verbose">
        /// Output all generated arguments.
        /// </param>
        [Property(DisplayName = "Attribute Inputs Method", Skip = "Nothing is asserted")]
        public void Property(
            Type[] Arbitrary,
            string DisplayName,
            int EndSize,
            int MaxFail,
            int MaxTest,
            bool QuietOnSuccess,
            string Replay,
            string Skip,
            int StartSize,
            bool Verbose)
        {
            Console.Write(DisplayName);
        }





        [Property(MaxFail = 5)]
        public void MaxFailTest2(int x, int y)
        {
            var stringData = x + ", " + y;

            System.Diagnostics.Debug.WriteLine(stringData);

            //return x.Equals(y).When(x >= 0).;

            //When(y >= 0);

            //System.Diagnostics.Debug.WriteLine("Hello!");

            //(x + y).Should().BeGreaterThan(0);

            //Prop.ForAll<int>((x) => System.Diagnostics.Debug.WriteLine(x)).QuickCheck();
        }

        /// <summary>
        /// Will keep running the default number of tests when x > 0.
        /// The tests stop running and is deemed failed on the fifth time that x less than or equal 0
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Property(MaxFail = 5)]
        public Property ShouldPass(int x, int y)
        {
            var stringData = x + ", " + y;
            System.Diagnostics.Debug.WriteLine(stringData);

            return true.When(x > 0);
        }

        /// <summary>
        /// DisplayName is the name displayed when the test is skipped, 
        /// Giving Skip a value skips this test, and the value/message is displayed as the test explorers output
        /// </summary>
        [Property(DisplayName = "Attribute Inputs Method", Skip = "Nothing is asserted")]
        public void SkipTest1()
        {

        }






        // https://fscheck.github.io/FsCheck/QuickStart.html#Straightforward-integration-with-any-unit-test-framework
        // https://github.com/fscheck/FsCheck/blob/master/src/FsCheck/RunnerExtensions.fs#L108-108
        // https://fscheck.github.io/FsCheck/reference/fscheck-config.html
        // https://fsharpforfunandprofit.com/posts/property-based-testing/
        // http://www.aaronstannard.com/fscheck-property-testing-csharp-part1/
        // https://fscheck.github.io/FsCheck/TestData.html
        // https://stackoverflow.com/questions/40591229/fscheck-doesnt-generate-random-enough-data/40591931#40591931
        // http://blog.ploeh.dk/2015/09/08/ad-hoc-arbitraries-with-fscheckxunit/



        /// <summary>
        /// https://channel9.msdn.com/Events/Ignite/New-Zealand-2016/M360
        /// 15min in
        /// 
        /// </summary>
        /// <param name="ns"></param>
        [Property]
        public void MaxIsAMemberOfTheCollection(int[] ns)
        {
            // Max fails on the empty array situation
            if (ns.Length == 0)
            {
                return;
            }

            var max = ns.Max();
            ns.Should().Contain(max);
        }
    }
}
