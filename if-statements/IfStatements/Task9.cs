namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            bool condition = i > 0;
            i = Math.Abs(i);

            if (b)
            {
                return !((i > 4 && i < 9) || i == 0);
            }
            else
            {
                if (condition)
                {
                    return !((i > 3 && i < 8) || i == 0);
                }
                else
                {
                    return !((i > 4 && i < 9) || i == 0);
                }
            }
        }
    }
}
