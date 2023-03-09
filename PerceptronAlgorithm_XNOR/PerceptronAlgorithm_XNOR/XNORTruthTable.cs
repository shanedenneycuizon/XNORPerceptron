using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronAlgorithm_XNOR
{
    public class XNORTruthTable
    {  
        private int x1 = -1;
        private int x2 = -1;
        private int y = -1;

        public XNORTruthTable(){}
        public XNORTruthTable(int x1,int x2)
        {
            this.x1 = x1;
            this.x2 = x2;
        }

        public int GetExpectedOutput()
        { 
            //  x1   x2    y'
            //  -1   -1     1
            //  -1    1    -1
            //   1   -1    -1
            //   1    1     1

            if(x1==-1 && x2 == -1)
            {
                y = 1;
            }
            else if (x1 == -1 && x2 == 1)
            {
                y = -1;
            }
            else if (x1 == 1 && x2 == -1)
            {
                y = -1;
            }
            else if (x1 == 1 && x2 == 1)
            {
                y = 1;
            }
            return y;
        }
    }
}
