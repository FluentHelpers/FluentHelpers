using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentHelpers;

namespace Test.FluentHelpers.IsEmpty
{
    public class ListIsNull
    {

        [Fact]
        public void IsNull()
        {
            List<string> listString = null;
            Dictionary<string, string> dictionary = null;

            Assert.True(listString.IsNull());
            Assert.True(dictionary.IsNull());

        }

        


    }
}
