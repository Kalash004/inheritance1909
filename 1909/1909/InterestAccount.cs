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
            this.precent = 10;
            this.interest = getInterest();
        }

        public virtual void setProcentage (int value)
        {
            if (value > 0) precent = value;
            else throw new Exception("Precent cant be negative");
            this.interest = getInterest();
        }

        public virtual int getProcentage ()
        {
            return precent;
        }

        protected virtual int getInterest()
        {
            return base.amount / precent;
        }

        public virtual void addInterest()
        {
            base.amount = base.amount + interest;
        }

        public override string ToString()
        {
            return base.ToString()+String.Format("Precent: {0}\nInterest: {1}\n",this.precent.ToString(),this.interest.ToString());
        }



    }
}
