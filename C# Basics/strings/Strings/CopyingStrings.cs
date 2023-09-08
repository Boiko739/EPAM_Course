namespace Strings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            var res = destination.ToCharArray();
            source.CopyTo(0, res, res.Length - 1, 1);
            return new string(res);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            var res = destination.ToCharArray();
            source.CopyTo(0, res, 0, 3);
            return new string(res);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            var res = destination.ToCharArray();
            source.CopyTo(0, res, 4, 5);
            return new string(res);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            var res = destination.ToCharArray();
            source.CopyTo(2, res, 5, 6);
            return new string(res);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            // Sorry for magic numbers
            var res = template.ToCharArray();
            regionCode.CopyTo(1, res, 0, 1);
            locationCode.CopyTo(4, res, 3, 2);
            dateCode.CopyTo(3, res, 7, 3);
            factoryCode.CopyTo(2, res, 12, 4);
            return new string(res);
        }
    }
}
