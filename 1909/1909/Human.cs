using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class Human
    {
        protected string name;

        public Human(string name)
        {
            this.name = name;
        }

        public String getName()
        {
            return name;
        }

        public virtual bool isLying()
        {
            Random random = new Random();
            int generated = random.Next(2);
            if (generated == 1) return false;
            else return true;
        }
    }
}
