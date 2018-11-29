using System;

namespace api.Service
{
    public class FibonacciService
    {
        const long minInput = -93;
        const long maxInput = 93;
        public int Calculate(long n)
        {
            if (n <= minInput || n >= maxInput)
            {
                throw new ArgumentException($"Invalid input '{n}'. It should be between -92 and 92");
            }

            return CalculateFibonacci(n);
        }

        int CalculateFibonacci(long n)
        {
            var sign = GetSign(n);

            n =  Math.Abs(n);

            if (n == 1 || n == 2)
            {
                return 1 * sign;
            }

            var fibonacci = new int[n];
            fibonacci[0] = 1;
            fibonacci[1] = 1;
            for (var index = 2; index <= n-1;index++)
            {  
                fibonacci[index] = fibonacci[index - 2] + fibonacci[index - 1];
            }

            return fibonacci[n-1] * sign;
        }

        int GetSign(long n)
        {
            if (n < 0)
            {
                n = Math.Abs(n);
                if (IsEven(n))
                {
                    return -1;
                }
            }

            return 1;
        }

        bool IsEven(long n)
        {
            return n % 2 == 0;
        }
    }
}