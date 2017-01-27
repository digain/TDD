using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class Dollar
    {
        int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }
        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;
            return Amount == dollar.Amount;
        }
    }
}
