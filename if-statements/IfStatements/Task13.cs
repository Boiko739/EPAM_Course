namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if (i == 0)
            {
                return 10;
            }

            if (b)
            {
                if (i > -5 && i < 4)
                {
                    return i < 0 ? i + 5 : i - 5;
                }
                else if (i < -8)
                {
                    return i + 5;
                }

                return i < 0 ? i : -i;
            }
            else
            {
                if (i > -5 && i < 6)
                {
                    return Math.Abs(i - 10);
                }

                return -i;
            }
        }
    }
}
