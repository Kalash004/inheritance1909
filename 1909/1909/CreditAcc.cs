using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class CreditAcc
    {
        private bool card;
        private int limit;
        private int id;
        private int balance;

        public CreditAcc(bool card, int limit, int id, int balance)
        {
            this.card = card;
            this.limit = limit;
            this.id = id;
            this.balance = balance;
        }

        public bool payCard(int value)
        {
            if (!card) throw new ArgumentException("User doenst have card"); 
            if (value<= limit )
            {
                balance = balance - value;
            } 
        }
    }
}
