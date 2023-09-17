namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
            return n > 0 ? n * n : n * -1;
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
            (int digit, int tensDigit, int hundretsDigit) = (n % 10, n / 10 % 10, n / 100);
            if (digit > tensDigit)
            {
                (digit, tensDigit) = (tensDigit, digit);
            }

            if (tensDigit > hundretsDigit)
            {
                (tensDigit, hundretsDigit) = (hundretsDigit, tensDigit);
            }

            if (digit > tensDigit)
            {
                (digit, tensDigit) = (tensDigit, digit);
            }

            return (hundretsDigit * 100) + (tensDigit * 10) + digit;
        }
    }
}
