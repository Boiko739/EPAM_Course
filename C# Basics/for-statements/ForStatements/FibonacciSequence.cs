namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            int fibonacciNumber = 0;
            int previousNum = 0;
            int beforePreviousNum = 1;

            for (int i = 0; i < n; i++)
            {
                fibonacciNumber = previousNum + beforePreviousNum;
                beforePreviousNum = previousNum;
                previousNum = fibonacciNumber;
            }

            return fibonacciNumber;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            int fibonacciNumber = GetFibonacciNumber((int)n);
            ulong product = 1;

            for (; fibonacciNumber > 0; fibonacciNumber /= 10)
            {
                product *= (ulong)fibonacciNumber % 10;
            }

            return n > 0 ? product : 0;
        }
    }
}
