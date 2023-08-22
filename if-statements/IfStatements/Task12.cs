namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            if (i > -6 && i < 5)
            {
                return i * (i - 1);
            }
            else if (i < -8 || i > 9)
            {
                return i < 0 ? i * i : -i * i;
            }

            return i;
        }
    }
}
