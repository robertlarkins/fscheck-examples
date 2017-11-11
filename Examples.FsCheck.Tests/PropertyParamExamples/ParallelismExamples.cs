using FsCheck.Xunit;

namespace Examples.FsCheck.Tests.PropertyParamExamples
{
    public class ParallelismExamples
    {
        [Property(Parallelism = 3)]
        public void SomeTest()
        {
            
        }

    }
}