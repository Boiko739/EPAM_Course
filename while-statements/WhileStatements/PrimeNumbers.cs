namespace WhileStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            uint i = 2;
            if (n < 2)
            {
                return false;
            }

            while (n + -i > 0)
            {
                if (n % i == 0)
                {
                    return false;
                }

                i++;
            }

            return true;
        }

        public static uint GetLastPrimeNumber(uint n)
        {
            uint i = 0;

            while (n + -i > 0)
            {
                if (IsPrimeNumber((uint)(n + -i)))
                {
                    return (uint)(n + -i);
                }

                i++;
            }

            return 0;
        }

        public static uint SumLastPrimeNumbers(uint n, uint count)
        {
            uint sum = 0;
            uint i = 0;

            while (n + -i > 0 && count > 0)
            {
                if (IsPrimeNumber((uint)(n + -i)))
                {
                    sum += (uint)(n + -i);
                    count--;
                }

                i++;
            }

            return sum;
        }
    }
}
