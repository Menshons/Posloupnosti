using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posloupnosti
{
    public class Problem
    {
        public int Number { get; set; }
        public string ProblemType { get; set; }

        public Problem(int number, string problemType)
        {
            Number = number;
            ProblemType = problemType;
        }
    }
}
