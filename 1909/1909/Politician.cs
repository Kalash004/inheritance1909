using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class Politician:Human
    {
        protected String name;
        public Politician(string name) : base(name)
        {
            this.name = name;
        }

        public override bool isLying()
        {
            return false;
        }
    }
}
