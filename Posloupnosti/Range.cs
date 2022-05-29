using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posloupnosti
{
    public class Range
    {
        public int Start { get; init; }
        public int End { get; init; }

        public Range(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}
