namespace IfStatements
{
    public static class Task6
    {
        public static int DoSomething(int i)
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
