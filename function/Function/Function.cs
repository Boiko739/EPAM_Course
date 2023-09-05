namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            if (array.Length < 2)
            {
                return true;
            }

            var comparable = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (order == SortOrder.Ascending ? array[i] >= comparable : array[i] <= comparable)
                {
                    comparable = array[i];
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (IsSorted(array, order))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] += i;
                }
            }
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double res = a;

            for (int i = 1; i < n; i++)
            {
                a += t;
                res *= a;
            }

            return res;
        }

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double res = 0.0;

            for (; t < 1 ? a > alim : a < alim; a *= t)
            {
                res += a;
            }

            return res;
        }
    }
}
