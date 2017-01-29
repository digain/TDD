using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class Money : IExpression
    {
        protected int amount;
        protected string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }
        public IExpression Plus(Money addend)
        {
            return new Money(amount + addend.amount, currency);
        }
        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }
        public override bool Equals(object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && currency == money.currency;
        }
        public static Money Dollar(int amount)
        {
            return new Money(amount,"USD");
        }
        public static Money Franc(int amount)
        {
            return new Money(amount,"CHF");
        }

        public string Currency()
        {
            return currency;
        }
    }
}
