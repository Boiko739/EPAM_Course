namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("n should be greater than 0.");
            }

            double sum = 0;
            double i = 1;
            while (n >= i)
            {
                int poweredMinusOne = i % 2 != 0 ? -1 : 1;
                double firstMult = 0.5;
                double secondMult = 1 / (i + 0.5);
                var res = firstMult * secondMult * poweredMinusOne;
                sum += res;
                i++;
            }

            return sum;
        }
    }
}
