using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.CamelCase
{
    public class StringCamelCase
    {

        [Fact]
        public void Test1()
        {
            Assert.Equal("helloWorld", "hello World".CamelCase());
            Assert.Equal("helloWorld", " hello World".CamelCase());
            Assert.Equal("helloWorld", " hello World ".CamelCase());
            Assert.Equal("helloWorld", "  hello  World  ".CamelCase());
        }

    }
}
