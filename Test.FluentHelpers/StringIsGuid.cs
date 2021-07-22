using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers
{
    public class StringIsGuid
    {

        [Fact]
        public void Test1()
        {


            Assert.True("8eb06d03-aaf5-491c-9a1f-d16f19a58d61".IsGuid());
            Assert.True("{8eb06d03-aaf5-491c-9a1f-d16f19a58d61}".IsGuid());
            Assert.True("8eb06d03aaf5491c9a1fd16f19a58d61".IsGuid());

            string test = null;
            Assert.False(test.IsGuid());
            Assert.False("".IsGuid());
            Assert.False("Hi, ".IsGuid());
            Assert.False("qweqwe".IsGuid());
            Assert.False("8eb06d03--aaf5--491c--9a1f--d16f19a58d61".IsGuid());


            
        }

    }
}
