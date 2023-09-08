namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            (arrayToSearch, rangeStart, rangeEnd) = CheckForExceptions(arrayToSearch, rangeStart, rangeEnd);

            for (int i = 0; i < rangeStart.Length; i++)
            {
                if (rangeStart[i] > rangeEnd?[i])
                {
                    throw new ArgumentException("The range start value cannot be greater than the range end value.");
                }
            }

            int count = 0;
            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd?[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd, int startIndex, int count)
        {
            int floatCount = 0;
            int j;
            int i = 0;

            (arrayToSearch, rangeStart, rangeEnd) = CheckForExceptions(arrayToSearch, rangeStart, rangeEnd);
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count cannot be less than zero.");
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be less than zero.");
            }
            else if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be freater than array length.");
            }

            do
            {
                if (rangeStart.Length == 0)
                {
                    return floatCount;
                }
                else if (rangeStart[i] > rangeEnd[i])
                {
                    throw new ArgumentException("The range start value cannot be greater than the range end value.");
                }
            }
            while (++i < rangeStart.Length);

            if (arrayToSearch.Length == 0)
            {
                return floatCount;
            }

            i = startIndex;
            do
            {
                if (count-- == 0)
                {
                    break;
                }

                j = 0;
                do
                {
                    if (arrayToSearch?[i] >= rangeStart?[j] && arrayToSearch?[i] <= rangeEnd?[j])
                    {
                        floatCount++;
                    }
                }
                while (++j < rangeStart?.Length);
            }
            while (++i < arrayToSearch?.Length);
            return floatCount;
        }

        private static (float[], float[], float[]) CheckForExceptions(float[]? arrayToSearch, float[]? rangeStart, float[]? rangeEnd)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (rangeStart == null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }
            else if (rangeEnd == null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }
            else if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("Ranges cannot contain different number of elements.");
            }

            return (arrayToSearch, rangeStart, rangeEnd);
        }
    }
}
