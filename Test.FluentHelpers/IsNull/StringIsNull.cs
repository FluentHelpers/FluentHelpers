using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.IsEmpty
{
    public class StringIsEmpty
    {

        [Fact]
        public void IsNullOrEmpty()
        {
            string valueNull = null;

            Assert.True("".IsNullOrEmpty());
            Assert.False(" ".IsNullOrEmpty());
            Assert.True(valueNull.IsNullOrEmpty());

            Assert.False("Lorem ipsum dolor sit amet".IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrWhiteSpace()
        {
            string valueNull = null;

            Assert.True("".IsNullOrWhiteSpace());
            Assert.True(" ".IsNullOrWhiteSpace());
            Assert.True(valueNull.IsNullOrWhiteSpace());

            Assert.False("Lorem ipsum dolor sit amet".IsNullOrWhiteSpace());
        }


    }
}
