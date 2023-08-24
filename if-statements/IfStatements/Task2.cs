namespace IfStatements
{
    public static class Task2
    {
        public static int DoSomething1(int i)
        {
            var result = i;
            if (i < 0 && i > -6)
            {
                result = -i;
            }
            else if (i < -5)
            {
                result = -(i * i);
            }

            return result;
        }

        public static int DoSomething2(int i)
        {
            if (i < 0 && i > -6)
            {
                return -i;
            }
            else if (i < -5)
            {
                return -(i * i);
            }

            return i;
        }

        public static int DoSomething3(int i) => i switch
        {
            < -5 => -(i * i),
            < 0 => -i,
            >= 0 => i
        };

        public static int DoSomething4(int i)
        {
            return i < -5 ? -(i * i) : Math.Abs(i);
        }
    }
}
