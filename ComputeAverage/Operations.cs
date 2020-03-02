using System;
using System.Collections.Generic;
using System.Text;

namespace ComputeAverage
{
    public class Operations
    {
        public int defaultNum = 100;

        public int Average(int num1, int num2 = 100)
        {
            return (num1 + num2) / 2;
        }
    }
}
