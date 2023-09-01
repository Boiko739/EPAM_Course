namespace LookingForArrayElements
{
    public static class DecimalCounter
    {
        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            int count = 0;
            int i;
            int j;

            (arrayToSearch, ranges) = CheckForNull(arrayToSearch, ranges);
            i = 0;
            do
            {
                if (ranges.Length > 0 && ranges[i]?.Length != 2 && ranges[i]?.Length != 0)
                {
                    throw new ArgumentException("The length of the range cannot be greater or less than 2.");
                }
            }
            while (++i < ranges.Length);
            if (ranges.Length == 0)
            {
                return count;
            }

            i = 0;
            do
            {
                j = 0;
                do
                {
                    if (ranges[j]?.Length == 0)
                    {
                        break;
                    }
                    else if (arrayToSearch.Length == 0)
                    {
                        return 0;
                    }
                    else if (ranges[j]?[0] > ranges[j]?[1])
                    {
                        throw new ArgumentException("The range start value cannot be greater than the range end value.");
                    }
                    else if (arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                    {
                        count++;
                        break;
                    }
                }
                while (++j < ranges.Length);
            }
            while (++i < arrayToSearch.Length);

            return count;
        }

        /// <summary>
        /// Searches an array of decimals for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="ranges">One-dimensional, zero-based <see cref="Array"/> of range arrays.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetDecimalsCount(decimal[]? arrayToSearch, decimal[]?[]? ranges, int startIndex, int count)
        {
            int decimalsCount = 0;

            (arrayToSearch, ranges) = CheckForNull(arrayToSearch, ranges);

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges.Length > 0 && ranges[i]?.Length != 2 && ranges[i]?.Length != 0)
                {
                    throw new ArgumentException("The length of the range cannot be greater or less than 2.");
                }
            }

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
            else if (ranges.Length == 0)
            {
                return decimalsCount;
            }

            for (int i = startIndex; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < ranges.Length; j++)
                {
                    if (ranges[j]?.Length == 0)
                    {
                        break;
                    }
                    else if (arrayToSearch.Length == 0)
                    {
                        return 0;
                    }
                    else if (ranges[j]?[0] > ranges[j]?[1])
                    {
                        throw new ArgumentException("The range start value cannot be greater than the range end value.");
                    }
                    else if (i - startIndex >= count)
                    {
                        break;
                    }
                    else if (arrayToSearch[i] >= ranges[j]?[0] && arrayToSearch[i] <= ranges[j]?[1])
                    {
                        decimalsCount++;
                        break;
                    }
                }
            }

            return decimalsCount;
        }

        private static (decimal[], decimal[]?[]) CheckForNull(decimal[]? arrayToSearch, decimal[]?[]? ranges)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (ranges == null)
            {
                throw new ArgumentNullException(nameof(ranges));
            }

            for (int i = 0; i < ranges.Length; i++)
            {
                if (ranges[i] == null)
                {
                    throw new ArgumentNullException(nameof(ranges));
                }
            }

            return (arrayToSearch, ranges);
        }
    }
}
