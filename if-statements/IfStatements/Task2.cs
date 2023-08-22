namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            return i < -5 ? -(i * i) : Math.Abs(i);
        }

        public static int DoSomething2(int i)
        {
            return DoSomething1(i);
        }
    }
}
