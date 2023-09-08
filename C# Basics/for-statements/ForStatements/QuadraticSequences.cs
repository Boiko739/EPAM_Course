namespace ForStatements
{
    public static class QuadraticSequences
    {
        public static uint CountQuadraticSequenceTerms(long a, long b, long c, long maxTerm)
        {
            uint i = 0;
            for (long term = 0; term < maxTerm; i++)
            {
                term = (a * i * i) + (b * i) + c;
            }

            return i > 0 ? i - 1 : 0;
        }

        public static ulong GetQuadraticSequenceTermsProduct1(uint count)
        {
            uint a = 7, b = 4, c = 2;
            ulong product = 1;
            for (uint i = 1; i <= count; i++)
            {
                product *= (a * i * i) + (b * i) + c;
            }

            return product;
        }

        public static ulong GetQuadraticSequenceProduct2(long a, long b, long c, long startN, long count)
        {
            ulong product = 1;
            for (long i = 1; count > 0; i++)
            {
                if (i >= startN)
                {
                    product *= (ulong)((a * i * i) + (b * i) + c);
                    count--;
                }
            }

            return product;
        }
    }
}
