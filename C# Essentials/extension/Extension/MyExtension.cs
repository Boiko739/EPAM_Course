using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension
{
    public static class MyExtension
    {
        /// <summary>
        /// Mehod that return sum of  'n' digit
        /// </summary>        
        /// <param name="n">Element parameter</param>
        /// <returns>Integer value</returns>
        public static int SummaDigit(this int n)
        {
            int sum = 0;
            n = n > 0 ? n : -n;
            for (; n > 0; n /= 10)
            {
                sum += n % 10;
            }

            return sum;
        }

        /// <summary>
        /// Method that return sum of 'n' element and reverse of 'n'
        /// </summary>
        /// <param name="n">Element parameter</param>
        /// <returns>Ulong value</returns>
        public static ulong SummaWithReverse(this uint n)
        {
            uint reversed = 0;
            for (uint i = n; i > 0; i /= 10)
            {
                reversed = (reversed * 10) + (i % 10);
            }

            return reversed + n;
        }

        /// <summary>
        /// Method that count amount of elements in string , which are not letters of the latin alphabet.
        /// </summary>
        /// <param name="str">String parameter</param>
        /// <returns>Integer value</returns>
        public static int CountNotLetter(this string str)
        {
            return str.Count(c => !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')));
        }


        /// <summary>
        /// Method that checks whether day is weekend or not 
        /// </summary>
        /// <param name="day">DayOfWeek parameter</param>
        /// <returns>Bool value</returns>
        public static bool IsDayOff(this DayOfWeek day)
        {
            return day == DayOfWeek.Saturday || day == DayOfWeek.Sunday;
        }


        /// <summary>
        /// Method that return positive ,even  element from collection 
        /// </summary>
        /// <param name="numbers">Collection of elements</param>
        /// <returns>IEnumerable -int collection  </returns>
        public static IEnumerable<int> EvenPositiveElements(this IEnumerable<int> numbers)
        {
            var evenPositiveElements = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 2 == 0 && number > 0)
                {
                    evenPositiveElements.Add(number);
                }
            }

            return evenPositiveElements;
        }
    }
}
