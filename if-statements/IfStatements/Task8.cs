namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            i = Math.Abs(i);
            return b ?
                !((i > 3 && i < 7) || i == 0) :
                !((i > 2 && i < 7) || i == 0);
        }
    }
}
