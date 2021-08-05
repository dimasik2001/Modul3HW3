using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW3
{
    public class Class2
    {
        public double ResultOfPow { get; private set; }
        public Func<double, bool> Calc(Func<int, int, int> func, int x, int y)
        {
            ResultOfPow = func.Invoke(x, y);
            return Result;
        }

        public bool Result(double arg)
        {
            return ResultOfPow % arg == 0;
        }
    }
}
