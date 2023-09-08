namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            // My second option
            if (i >= -5 && i < 5)
            {
                return (i * i) - i;
            }
            else if (i < -8 || i >= 10)
            {
                return i < 0 ? i * i : -i * i;
            }

            return i;
        }

        public static int DoSomething1(int i)
        {
            // My first option
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
