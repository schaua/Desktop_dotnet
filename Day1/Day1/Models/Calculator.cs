using System;
using System.Collections.Generic;
using System.Text;

namespace Day1.Models
{
    public class Calculator
    {
        private readonly Func<int, int> _op;

        public Calculator(Func<int, int> op_)
        {
            _op = op_;
        }

        public int GetResult(int n)
        {
            return _op(n);
        }
    }
}
