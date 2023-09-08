namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number; return -1 if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer; return -1 if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number cannot be less than 0.", nameof(number));
            }

            int result = -1;
            int pow = 1;
            int numsToAdd = 0;
            bool swapped = false;

            for (int i = number; i > 10; i /= 10)
            {
                pow *= 10;
                if (i % 10 > (i / 10) % 10)
                {
                    result = Swap(i);
                    swapped = true;
                    numsToAdd = (numsToAdd * 10) + ((i / 10) % 10);
                }
                else
                {
                    numsToAdd = (numsToAdd * 10) + (i % 10);
                }

                if (swapped)
                {
                    numsToAdd = SortByDesc(numsToAdd);
                    result = (result * pow) + numsToAdd;
                    break;
                }
            }

            return result > number ? result : -1;
        }

        private static int SortByDesc(int num)
        {
            int result = num;

            for (int i = num; i > 0; i /= 10)
            {
                if (i % 10 < (i / 10) % 10)
                {
                    result = (Swap(i) * 10) + ((i / 10) % 10);
                    break;
                }
            }

            return result;
        }

        private static int Swap(int number)
        {
            int units = number % 10;
            int tens = (number / 10) % 10;

            return ((number - (units + (tens * 10))) / 10) + units;
        }
    }
}
