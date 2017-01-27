using System;
using TDD.Models;
using Xunit;

namespace TDD.Tests
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            Assert.Equal(new Dollar(10), five.Times(2));            
            Assert.Equal(new Dollar(15),five.Times(3));
        }

        [Fact]
        public void TestFrancMultiplication()
        {
            var five = new Franc(5);
            Assert.Equal(new Franc(10), five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }


        [Fact]
        public void TestEquality()
        {
            Assert.Equal(new Dollar(5), new Dollar(5));
            Assert.NotEqual(new Dollar(5), new Dollar(6));
        }
    }
}
