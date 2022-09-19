using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class InterestAccountPoplatek:InterestAccount
    {
        protected int payment;

        public InterestAccountPoplatek(int id, int amount) : base(id, amount)
        {
        }

        public virtual void pay()
        {
            base.amount = base.amount + payment;
        }

        public void setPayment(int value)
        {
           this.payment = value;
        }

        public override string ToString()
        {
            return base.ToString()+String.Format("Payment: {0}\n",this.payment.ToString());
        }
    }
}
