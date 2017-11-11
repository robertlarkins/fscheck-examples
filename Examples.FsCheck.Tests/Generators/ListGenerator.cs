using FsCheck;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examples.FsCheck.Tests.Generators
{
    public class ListGenerator
    {
        public Gen<T> ChooseFrom<T>(T[] xs)
        {
            return from i in Gen.Choose(0, xs.Length-1) select xs[i];
        }

    }
}
