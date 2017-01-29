using System;
using TDD.Models;
using Xunit;

namespace TDD.Tests
{
    public class MoneyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = Money.Dollar(5);
            Assert.True(Money.Dollar(10).Equals(five.Times(2)));            
            Assert.True(Money.Dollar(15).Equals(five.Times(3)));
        }
        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
        }
        [Fact]
        public void TestCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }
        [Fact]
        public void TestSimpleAddition()
        {
            IExpression sum = Money.Dollar(5).Plus(Money.Dollar(5));
            Bank bank = new Bank();
            Money reduced = bank.Reduce(sum, "USD");
            Assert.True(reduced.Equals(Money.Dollar(10)));
        }
    }
}
