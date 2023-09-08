namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            const int MINIMUM_NOT_PRIME = 2;
            const int EXCEPTION = 4;
            if (n < MINIMUM_NOT_PRIME || n == EXCEPTION)
            {
                return false;
            }

            uint remaindOfN = n / 2;
            for (uint i = 2; i < remaindOfN; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                else
                {
                    remaindOfN = n / i;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            ulong sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (IsPrimeNumber((uint)i))
                {
                    for (int j = i; j > 0; j /= 10)
                    {
                        sum += (ulong)j % 10;
                    }
                }
            }

            return sum;
        }
    }
}
