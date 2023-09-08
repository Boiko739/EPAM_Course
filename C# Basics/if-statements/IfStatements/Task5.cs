namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            var result = i;

            if (i < 0 && i >= -5)
            {
                result = i + 5;
            }
            else if (i > 0 && i <= 5)
            {
                result = i - 5;
            }

            return result;
        }

        public static int DoSomething1(int i)
        {
            if (i < 0 && i >= -5)
            {
                return i + 5;
            }
            else if (i > 0 && i <= 5)
            {
                return i - 5;
            }

            return i;
        }
    }
}
