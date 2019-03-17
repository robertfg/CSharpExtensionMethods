using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Common
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return (value % 2) == 0;

            // Can also use bitwise operator:
            //return (value & 1) == 0;
        }
    }
}
