using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class Franc
    {
        int Amount;
        public Franc(int amount)
        {
            Amount = amount;
        }
        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;
            return Amount == dollar.Amount;
        }
    }
}
