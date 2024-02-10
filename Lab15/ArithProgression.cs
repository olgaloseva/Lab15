using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class ArithProgression : ISeries
    {
        int startValue;
        int step;
        int currValue;
        public int GetNext()
        {
            currValue=currValue+step;
            return currValue;
        }

        public void Reset()
        {
            currValue=startValue;
        }

        public void SetStart(int x)
        {
            startValue=x;
            currValue = startValue;
        }
        public void SetStep(int s)
        {
            step = s;
        }
    }
}
