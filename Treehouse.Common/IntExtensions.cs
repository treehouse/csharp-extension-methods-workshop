using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treehouse.Common
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return (value & 1) == 0;
        }
    }
}
