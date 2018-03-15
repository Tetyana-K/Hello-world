using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Base
    {
        private int privateVal;
        protected int protectedVal;
        public int publicVal;
        public Base (int a = 1 , int b = 2, int c = 3) 
        {
            this.privateVal = a;
            this.protectedVal = b;
            this.publicVal = c;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}" , this.privateVal, this.protectedVal, this.publicVal);
        }


    }

   
  public class Derived :  Base
    {
        private int privateValD;
        protected int protectedValD;
        public int publicValD;
        protected internal  int protinternalValD;

        public Derived (int aa, int bb, int cc, int a = 1, int b = 2, int c = 3): base(a, b, c )
        {
            this.privateValD = aa;
            this.protectedValD = bb;
            this.publicValD = cc;
            this.protinternalValD = 100;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2};  ", this.privateValD, this.protectedValD, this.publicValD) + base.ToString();
        }


    }
}
