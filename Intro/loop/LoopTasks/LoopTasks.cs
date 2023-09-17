using System;

namespace LoopTasks
{
    public static class LoopTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static int SumOfOddDigits(int n)
        {
            int result = 0;
            for (; n > 0; n /= 10)
            {
                int digit = n % 10;
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }

            return result;
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int NumberOfUnitsInBinaryRecord(int n)
        {
            int result = 0;
            var charArray = Convert.ToString(n, 2).ToCharArray();
            var bin = Array.ConvertAll(charArray, c => (int)char.GetNumericValue(c));
            for (int i = 0; i < bin.Length; i++)
            {
                result += bin[i];
            }

            return result;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static int SumOfFirstNFibonacciNumbers(int n)
        {
            int result = 0;
            int fibonacciNumber = 0;
            int previousNum = 0;
            int beforePreviousNum = 1;

            for (int i = 0; i < n; i++)
            {
                result += fibonacciNumber;
                fibonacciNumber = previousNum + beforePreviousNum;
                beforePreviousNum = previousNum;
                previousNum = fibonacciNumber;
            }

            return result;
        }
    }
}