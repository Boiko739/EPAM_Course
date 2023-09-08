using System.Globalization;

namespace Strings
{
    public static class Manipulations
    {
        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting1(string name)
        {
            return $"Hello, {name}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting1(string greeting, string name)
        {
            return $"{greeting}, {name.ToUpper(CultureInfo.CurrentCulture)}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting2(string name)
        {
            return $"Hello, {name.Trim()}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting2(string greeting, string name)
        {
            return $"{greeting.Trim()}, {name.Trim().ToLower(CultureInfo.CurrentCulture)}!";
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetHelloGreeting3(string template, string name)
        {
            return template.Replace("{name}", name, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Returns a greeting.
        /// </summary>
        public static string GetGreeting3(string template, string greeting, string name)
        {
            return template.Replace("{greeting}", greeting.ToLower(CultureInfo.CurrentCulture), StringComparison.OrdinalIgnoreCase)
                           .Replace("{name}", name.ToUpper(CultureInfo.CurrentCulture), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Returns refined code - without zero characters.
        /// </summary>
        public static string GetRefinedCode(string code)
        {
            return code.Replace("0", string.Empty, StringComparison.Ordinal);
        }

        /// <summary>
        /// Returns refined date - without dash characters.
        /// </summary>
        public static string GetRefinedDate(string date)
        {
            for (int i = 0; i < 2; i++)
            {
                date = date.Remove(date.IndexOf('-', 0, 5), 1);
            }

            return date;
        }
    }
}
