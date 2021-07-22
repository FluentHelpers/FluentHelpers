using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.Random
{
	public class StringRandom
	{
        [Fact]
        public void Test1()
        {
            Assert.Equal(10, random.String(10).Length);
            Assert.Equal(30, random.String(30, true).Length);
            Assert.Equal(56, random.String(56, true, true, true).Length);
        }
    }
}
