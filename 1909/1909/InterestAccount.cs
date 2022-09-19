using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class InterestAccount : Account
    {
        protected int precent;
        protected int interest;

        public InterestAccount(int id, int amount) : base(id, amount)
        {
            this.precent = 0;
            this.interest = getInterest();
        }

        public void setProcentage (int value)
        {
            if (value > 0) precent = value;
            else throw new Exception("Precent cant be negative");
            this.interest = getInterest();
        }

        public int getProcentage ()
        {
            return precent;
        }

        private int getInterest()
        {
            return base.amount / precent;
        }

        private void addInterest()
        {
            base.amount = base.amount + interest;
        }



    }
}
