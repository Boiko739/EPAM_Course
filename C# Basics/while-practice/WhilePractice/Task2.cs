namespace WhilePractice
{
    public static class Task2
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
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
                int poweredMinusOne = i % 2 != 0 ? 1 : -1;
                double firstMult = 1 / i;
                double secondMult = 1 / (i + 1);
                var res = firstMult * secondMult * poweredMinusOne;
                sum += res;
                i++;
            }

            return sum;
        }
    }
}
