namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string? str, char[]? chars)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }

            int charsCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (str[i] == chars[j])
                    {
                        charsCount++;
                    }
                }
            }

            return charsCount;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }
            else if (endIndex < 0 || endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "End index cannot be less than zero or greater than the string length.");
            }
            else if (startIndex < 0 || endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "Start index cannot be less than zero or greater than the string length.");
            }
            else if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "Start index cannot be greater than the end index.");
            }

            int charsCount = 0;
            int i = startIndex;
            int j = 0;
            while (i < str.Length)
            {
                if (i > endIndex)
                {
                    break;
                }

                j = 0;
                while (j < chars.Length)
                {
                    if (str[i] == chars[j])
                    {
                        charsCount++;
                    }

                    j++;
                }

                i++;
            }

            return charsCount;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string? str, char[]? chars, int startIndex, int endIndex, int limit)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (chars == null)
            {
                throw new ArgumentNullException(nameof(chars));
            }
            else if (startIndex < 0 || startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "Start index cannot be less than zero or greater than the string length.");
            }
            else if (endIndex < 0 || endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex), "End index cannot be less than zero or greater than the string length.");
            }
            else if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be greater than the end index.");
            }
            else if (limit < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(limit), "Limit cannot be less than zero.");
            }

            int charCount = 0;
            int i = startIndex;
            int j = 0;
            if (str.Length > 0 && chars.Length > 0)
            {
                do
                {
                    j = 0;
                    do
                    {
                        if (i > endIndex || limit == 0)
                        {
                            break;
                        }
                        else if (str[i] == chars[j])
                        {
                            charCount++;
                            limit--;
                        }

                        j++;
                    }
                    while (j < chars.Length);
                    i++;
                }
                while (i < str.Length);
            }

            return charCount;
        }
    }
}
