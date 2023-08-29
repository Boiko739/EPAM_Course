namespace WhilePractice
{
    public static class Task3
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
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
            while (i <= n)
            {
                double powedI = (1 / i) * (1 / i) * (1 / i) * (1 / i) * (1 / i);
                sum += powedI;
                i++;
            }

            return sum;
        }
    }
}
