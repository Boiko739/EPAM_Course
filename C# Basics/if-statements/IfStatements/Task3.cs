namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            bool result;

            if (b)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        public static bool DoSomething2(bool b)
        {
            if (b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool DoSomething3(bool b)
        {
            return !b;
        }
    }
}
