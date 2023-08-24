namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
        {
            var result = i;

            if (b && i > -7 && i < 7)
            {
                result = 7 - i;
            }
            else if (!b && (i <= -5 || i >= 5))
            {
                result = i + 5;
            }

            return result;
        }

        public static int DoSomething1(bool b, int i)
        {
            if (b)
            {
                if (i >= 0 && i < 7)
                {
                    return 7 - i;
                }
                else if (i < 0 && i > -7)
                {
                    return Math.Abs(i) + 7;
                }

                return i;
            }
            else
            {
                return i > -5 && i < 5 ? i : i + 5;
            }
        }
    }
}
