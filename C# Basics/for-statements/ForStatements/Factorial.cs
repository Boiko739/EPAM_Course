namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int res = 1;

            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            return res;
        }

        public static int SumFactorialDigits(int n)
        {
            int sum = 0;

            for (int product = GetFactorial(n); product > 0; product /= 10)
            {
                sum += product % 10;
            }

            return sum;
        }
    }
}
