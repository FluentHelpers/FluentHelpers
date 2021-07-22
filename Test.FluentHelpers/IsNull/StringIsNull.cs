using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.IsEmpty
{
    public class StringIsNull
    {
        [Fact]
        public void IsNull()
        {
            string test = null;
            Assert.True(test.IsNull());

            Assert.False("".IsNull());
            Assert.False(" ".IsNull());

            Assert.False("Lorem ipsum dolor sit amet".IsNull());
        }

        [Fact]
        public void IsNullOrWhiteSpace()
        {
            string test = null;
            Assert.True(test.IsNullOrWhiteSpace());
            Assert.True("".IsNullOrWhiteSpace());
            Assert.True(" ".IsNullOrWhiteSpace());
            Assert.False("Lorem ipsum dolor sit amet".IsNullOrWhiteSpace());
        }

        [Fact]
        public void IsNullOrEmpty()
        {
            string test = null;
            Assert.True(test.IsNullOrEmpty());
            Assert.True("".IsNullOrEmpty());
            Assert.False(" ".IsNullOrEmpty());
            Assert.False("Lorem ipsum dolor sit amet".IsNullOrEmpty());
        }

     




    }
}
