namespace WhileStatements
{
    public static class GeometricSequences
    {
        public static uint SumGeometricSequenceTerms1(uint a, uint r, uint n)
        {
            int i = 0;
            uint sum = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= r;
                    j++;
                }

                sum += a * rpow;
                i++;
            }

            return sum;
        }

        public static uint SumGeometricSequenceTerms2(uint n)
        {
            const uint firstTerm = 13;
            const uint commonRatio = 3;
            int i = 0;
            uint sum = 0;

            while (i < n)
            {
                uint j = 0;
                uint rpow = 1;
                while (j < i)
                {
                    rpow *= commonRatio;
                    j++;
                }

                sum += firstTerm * rpow;
                i++;
            }

            return sum;
        }

        public static uint CountGeometricSequenceTerms3(uint a, uint r, uint maxTerm)
        {
            int i = 0;
            uint count = 0;
            uint rpow = 1;
            uint j;

            while (a * rpow <= maxTerm)
            {
                count++;
                j = 0;
                rpow = 1;

                while (j <= i)
                {
                    rpow *= r;
                    j++;
                }

                i++;
            }

            return count;
        }

        public static uint CountGeometricSequenceTerms4(uint a, uint r, uint n, uint minTerm)
        {
            // This task turned out incredibly difficult
            uint count = 0;
            uint i = 0;

            while (i < n)
            {
                if (a >= minTerm)
                {
                    count++;
                }

                a *= r;
                i++;
            }

            return count;
        }
    }
}
