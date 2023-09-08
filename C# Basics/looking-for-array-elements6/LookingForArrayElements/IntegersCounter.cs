namespace LookingForArrayElements
{
    public static class IntegersCounter
    {
        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor)
        {
            (arrayToSearch, elementsToSearchFor) = CheckArraysForNull(arrayToSearch, elementsToSearchFor);

            int count = 0;
            for (int i = 0; i < elementsToSearchFor.Length; i++)
            {
                for (int j = 0; j < arrayToSearch.Length; j++)
                {
                    if (elementsToSearchFor[i] == arrayToSearch[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        /// <summary>
        /// Searches an array of integers for elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>, and returns the number of occurrences of the elements withing the range of elements in the <see cref="Array"/> that starts at the specified index and contains the specified number of elements.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of integers to search.</param>
        /// <param name="elementsToSearchFor">One-dimensional, zero-based <see cref="Array"/> that contains integers to search for.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the elements that are in <paramref name="elementsToSearchFor"/> <see cref="Array"/>.</returns>
        public static int GetIntegersCount(int[]? arrayToSearch, int[]? elementsToSearchFor, int startIndex, int count)
        {
            int result = 0;
            int i = startIndex;
            int j = 0;

            (arrayToSearch, elementsToSearchFor) = CheckArraysForNull(arrayToSearch, elementsToSearchFor);
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

            while (i < arrayToSearch.Length)
            {
                j = 0;
                if (count-- == 0)
                {
                    break;
                }

                while (j < elementsToSearchFor.Length)
                {
                    if (arrayToSearch[i] == elementsToSearchFor[j])
                    {
                        result++;
                    }

                    j++;
                }

                i++;
            }

            return result;
        }

        private static (int[], int[]) CheckArraysForNull(int[]? arrayToSearch, int[]? elementsToSearchFor)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (elementsToSearchFor == null)
            {
                throw new ArgumentNullException(nameof(elementsToSearchFor));
            }

            return (arrayToSearch, elementsToSearchFor);
        }
    }
}
