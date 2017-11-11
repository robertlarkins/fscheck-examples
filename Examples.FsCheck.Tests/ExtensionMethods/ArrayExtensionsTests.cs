using Examples.FsCheck.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Examples.FsCheck.Tests.ExtensionMethods
{
    public class ArrayExtensionsTests
    {
        [Fact]
        public void TestExtension()
        {
            // Arrange
            var array = new[] { 1, 2, 3 };

            // Act
            var reversedArray = array.Reverse();

            // Assert


        }
    }
}
