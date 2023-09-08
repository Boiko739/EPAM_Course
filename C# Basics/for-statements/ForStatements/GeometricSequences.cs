namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong product = 1;
            for (uint i = 0; i < n; i++)
            {
                uint rpow = 1;
                for (int j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                product *= a * rpow;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            const int FIRST_TERM = 5;
            const int COMMON_RATIO = 3;
            ulong sum = 0;
            for (uint i = 0; i < n; i++)
            {
                uint rpow = 1;
                for (int j = 0; j < i; j++)
                {
                    rpow *= COMMON_RATIO;
                }

                sum += FIRST_TERM * rpow;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong i = 0;
            uint term = a;
            for (; term <= maxTerm;)
            {
                i++;
                uint rpow = 1;
                for (ulong j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                term = a * rpow;
            }

            return i;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            uint i = n - 1;
            for (; ;)
            {
                uint rpow = 1;
                for (int j = 0; j < i; j++)
                {
                    rpow *= r;
                }

                uint term = a * rpow;
                if (term < minTerm && i == n - 1)
                {
                    return 0;
                }
                else if (term <= minTerm || i == 0)
                {
                    break;
                }

                i = i > 0 ? i - 1 : i;
            }

            return n - i;
        }
    }
}
