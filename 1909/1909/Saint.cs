using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1909
{
    internal class Saint:Human
    {
        protected String name;
        public Saint(string name) : base(name)
        {
            this.name = name;
        }

        public override bool isLying()
        {
            return true;
        }
    }
}
