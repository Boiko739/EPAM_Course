namespace GettingArrayElementIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOf(ushort[]? arrayToSearch, ushort value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = 0;
            while (i < arrayToSearch.Length)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetIndexOf(ushort[]? arrayToSearch, ushort value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "StartIndex is less than zero.");
            }
            else if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "StartIndex is greater than array length.");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count is less than zero.");
            }

            int i = startIndex;
            while (i < arrayToSearch.Length)
            {
                if (i - startIndex >= count)
                {
                    break;
                }
                else if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetLastIndexOf(ushort[]? arrayToSearch, ushort value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = arrayToSearch.Length - 1;
            while (i >= 0)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }

        public static int GetLastIndexOf(ushort[]? arrayToSearch, ushort value, int startIndex, int count)
        {
            int lastPosition = startIndex + count;

            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "StartIndex is less than zero.");
            }
            else if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "StartIndex is greater than array length.");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count is less than zero.");
            }
            else if (lastPosition > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastPosition - 1;
            while (i >= startIndex)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }
    }
}
