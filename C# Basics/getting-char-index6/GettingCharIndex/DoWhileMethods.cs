﻿namespace GettingCharIndex
{
    public static class DoWhileMethods
    {
        public static int GetIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int ind = -1;
            int i = 0;
            if (str.Length > 0)
            {
                do
                {
                    if (str[i] == value)
                    {
                        ind = i;
                        break;
                    }

                    i++;
                }
                while (i < str.Length);
            }

            return ind;
        }

        public static int GetIndexOfChar(string? str, char value, int startIndex, int count)
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

            int ind = -1;
            int i = startIndex;
            if (str.Length > 0)
            {
                do
                {
                    if (str.Length == 0 || i - startIndex >= count)
                    {
                        break;
                    }
                    else if (str[i] == value)
                    {
                        ind = i;
                        break;
                    }

                    i++;
                }
                while (i < str.Length);
            }

            return ind;
        }

        public static int GetLastIndexOfChar(string? str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            int currentCharIndex = str.Length - 1;
            if (currentCharIndex < 0)
            {
                return -1;
            }

            do
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }
            while (currentCharIndex >= 0);

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

            int currentCharIndex = startIndex + count - 1;
            if (currentCharIndex < 0)
            {
                return -1;
            }

            do
            {
                char currentChar = str[currentCharIndex];
                if (currentChar == value)
                {
                    return currentCharIndex;
                }

                currentCharIndex--;
            }
            while (currentCharIndex >= startIndex);

            return -1;
        }
    }
}
