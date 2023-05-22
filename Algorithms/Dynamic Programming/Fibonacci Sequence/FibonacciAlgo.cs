using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Dynamic_Programming.Fibonacci_Sequence
{
    internal class FibonacciAlgo
    {
        public static int Fibonacci(int n)
        {
            int[] fib = new int[n + 2];

            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[n];
        }
    }
}
