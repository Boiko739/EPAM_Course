namespace IfStatements
{
    public static class Task7
    {
        public static int DoSomething(bool b, int i)
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
