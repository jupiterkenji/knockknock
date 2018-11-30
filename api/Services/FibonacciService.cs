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

            int first = 0;
            int second = 1;

            for (var index = 0; index < number; index++)
            {
                var firstTemp = first;
                first = second;

                second = firstTemp + first;
            }

            return first * sign;
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