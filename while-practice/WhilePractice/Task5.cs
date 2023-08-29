namespace WhilePractice
{
    public static class Task5
    {
        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetSequenceProduct(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be greater than 0.");
            }

            double result = 0;
            double i = 1;
            while (i <= n)
            {
                double expr = 1 + (1 / i * (1 / i));
                result = result == 0 ? expr : result * expr;
                i++;
            }

            return result;
        }
    }
}
