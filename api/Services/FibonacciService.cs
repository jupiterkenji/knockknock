using System;

namespace api.Service
{
    public class FibonacciService
    {
        const long minInput = -93;
        const long maxInput = 93;
        public int Calculate(long number)
        {
            if (number <= minInput || number >= maxInput)
            {
                throw new ArgumentException($"Invalid input '{number}'. It should be between -92 and 92");
            }

            return CalculateFibonacci(number);
        }

        int CalculateFibonacci(long number)
        {
            var sign = GetSign(number);

            number =  Math.Abs(number);

            // if (number == 1 || number == 2)
            // {
            //     return 1 * sign;
            // }

            // var fibonacci = new int[number];
            // fibonacci[0] = 1;
            // fibonacci[1] = 1;
            // for (var index = 2; index <= number-1;index++)
            // {  
            //     fibonacci[index] = fibonacci[index - 2] + fibonacci[index - 1];
            // }

            // return fibonacci[number-1] * sign;

            int a = 0;
            int b = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a * sign;
        }

        int GetSign(long number)
        {
            if (number < 0)
            {
                number = Math.Abs(number);
                if (IsEven(number))
                {
                    return -1;
                }
            }

            return 1;
        }

        bool IsEven(long number)
        {
            return number % 2 == 0;
        }
    }
}