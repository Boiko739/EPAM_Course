namespace GettingCharIndex
{
    public static class ForMethods
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int valueIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == value)
                {
                    valueIndex = i;
                    break;
                }
            }

            return valueIndex;
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            else if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be less than zero.");
            }
            else if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Count cannot be less than zero.");
            }
            else if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index cannot be greater than the length of the string param.");
            }

            int valueIndex = -1;
            for (int i = startIndex; i < str.Length; i++)
            {
                if (i - startIndex >= count)
                {
                    break;
                }
                else if (str[i] == value)
                {
                    valueIndex = i;
                    break;
                }
            }

            return valueIndex;
        }

        public static int GetLastIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            for (int currentCharIndex = str.Length - 1; currentCharIndex >= 0; currentCharIndex--)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }
            }

            return -1;
        }

        public static int GetLastIndexOfChar(string? str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length");
            }

            for (int currentCharIndex = startIndex + count - 1; currentCharIndex >= startIndex; currentCharIndex--)
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }
            }

            return -1;
        }
    }
}
