using FsCheck;
using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class MaxFailExamples
    {
        /// <summary>
        /// The When extension is needed for the MaxFail property param to work.
        /// </summary>
        /// <returns></returns>
        [Property(MaxFail = 5)]
        public Property PropertyParam_MaxFail_Example1()
        {
            return Prop.ForAll<int, int>((x, y) => (x == y).When(x > 0));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [Property(MaxFail = 5)]
        public Property PropertyParam_MaxFail_Example2a(int x, int y)
        {
            System.Diagnostics.Debug.WriteLine($"Value x = {x}, y = {y}");

            var result = x == y;

            return result.When(x > 0);
        }
    }
}
