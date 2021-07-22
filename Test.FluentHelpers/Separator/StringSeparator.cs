using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.Separator
{
    public class StringSeparator
    {
        [Fact]
        public void Test1()
        {

            Assert.Equal("12-34-56-78-90", "1234567890".Separator('-', 2));
            Assert.Equal("ABCDEF-GHIJKL-MNOP", "ABCDEFGHIJKLMNOP".Separator('-',6));
            Assert.Equal("ABCDE- FGHI-JK LM-NOPQR-STU V-WXYZ", "ABCDE FGHIJK LMNOPQRSTU VWXYZ".Separator('-',5));
        }
    }
}
