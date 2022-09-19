using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class Account
    {
        protected int id;
        protected int amount;

        public Account(int id, int amount)
        {
            this.id = id;
            this.amount = amount;
        } 

        public virtual void takeMoney(int value)
        {
            if (value > 0) value *= -1;
            if (value >= amount) amount -= value; 
        }

        public virtual void addMoney(int value)
        {
            if (value > 0) amount += value; 
        }

        public virtual int getStatus()
        {
            return amount;
        }

        public override string ToString()
        {
            return String.Format("ID: {0}\n" +
                "Amount: {0}\n",id.ToString(),amount.ToString());
        }

    }
}
