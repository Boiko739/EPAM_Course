namespace IfStatements
{
    public static class Task5
    {
        public static int DoSomething(int i)
        {
            if (i > 0 && i < 6)
            {
                return i - 5;
            }
            else if (i < 0 && i > -6)
            {
                return i + 5;
            }

            return i;
        }
    }
}
