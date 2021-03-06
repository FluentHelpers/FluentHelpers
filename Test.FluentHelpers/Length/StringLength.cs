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
            Assert.Equal( 3, "aa AA bb ba".LengthOnly('a'));
            Assert.Equal( 5, "aa aa bb ba".LengthOnly('a'));
            Assert.Equal( 4, "8eb06d03-aaf5-491c-9a1f-d16f19a58d61".LengthOnly('a'));
            Assert.Equal( 1, "Lorem ipsum dolor sit amet".LengthOnly('a'));
            Assert.Equal( 3, "Lorem ipsum dolor sit amet".LengthOnly('o'));
        }

        [Fact]
        public void LengthMax()
        {
            Assert.False("Lorem ipsum".LengthMax(5));
            Assert.False("Lorem ipsum".LengthMax(10));
            Assert.True("Lorem ipsum".LengthMax(11));
        }

        [Fact]
        public void LengthMin()
        {
            Assert.False("Lorem ipsum".LengthMin(15));
            Assert.True("Lorem ipsum".LengthMin(3));
        }


    }
}
