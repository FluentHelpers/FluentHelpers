using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.IsEmpty
{
    public class NumericIsNull
    {
        [Fact]
        public void IsNull()
        {
            int? test = null;
            Assert.True(test.IsNull());
        }


    }
}
