using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examples.FsCheck.ExtensionMethods
{
    public static class ArrayExtensions
    {
        public static T[] Reverse<T>(this T[] array)
        {
            return array;
        }
    }
}
