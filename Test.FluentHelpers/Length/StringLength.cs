using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers
{
    public class StringLength
    {

        [Fact]
        public void LengthOnly()
        {
            Assert.Equal( 4, "8eb06d03-aaf5-491c-9a1f-d16f19a58d61".LengthOnly('a'));
            Assert.Equal( 1, "Lorem ipsum dolor sit amet".LengthOnly('a'));
            Assert.Equal( 3, "Lorem ipsum dolor sit amet".LengthOnly('o'));
        }

        [Fact]
        public void LengthMax()
        {
            Assert.True("12345678".LengthMax(10));
            Assert.False("12345678".LengthMax(5));
        }

        [Fact]
        public void LengthMin()
        {
            Assert.False("123456789".LengthMin(10));
            Assert.True("12345678".LengthMin(3));
        }


    }
}
