using System;
using Xunit;

namespace NeuronNet.Test.XUnit
{
    public class NeuronTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1,1);
        }

        [Theory]
        [InlineData("2017-04-15")]
        [InlineData("2017-04-16")]
        [InlineData("2017-04-17")]
        public void Test2(string data)
        {
            Assert.Equal(1, 1);
        }
    }
}
