namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
        {
            var result = i;

            if (i < 0)
            {
                if (i >= -3)
                {
                    result = i + (2 * i);
                }
            }
            else
            {
                if (i <= 3)
                {
                    result = i - (i * i);
                }
            }

            return result;
        }

        public static int DoSomething1(int i)
        {
            if (i > 0 && i < 4)
            {
                return i - (i * i);
            }
            else if (i < 0 && i > -4)
            {
                return i * 3;
            }

            return i;
        }
    }
}
