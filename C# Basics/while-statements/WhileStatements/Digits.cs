namespace WhileStatements
{
    public static class Digits
    {
        public static ulong GetDigitsSum(ulong n)
        {
            ulong sum = 0;
            while (n >= 10)
            {
                sum += n % 10;
                n = (n - (n % 10)) / 10;
            }

            return sum + n;
        }

        public static ulong GetDigitsProduct(ulong n)
        {
            ulong prod = 1;
            while (n >= 10)
            {
                prod *= n % 10;
                n = (n - (n % 10)) / 10;
            }

            return prod * n;
        }
    }
}
