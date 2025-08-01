using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    internal class Money
    {
        public int Rands { get; set; }
        public int Cents { get; set; }

        public Money(int rands, int cents)
        {
            Rands = rands;
            Cents = cents;
            NormalizeCents();
        }   

        private void NormalizeCents()
        {
            if (Cents >= 100)
            {
                Rands += Cents / 100;
                Cents = Cents % 100;
            }
        }

        public static Money operator +(Money tillA, Money tillB)
        {
            var result = new Money(tillA.Rands + tillB.Rands, tillA.Cents + tillB.Cents);
            
            return result;
        }

       
    }
}
