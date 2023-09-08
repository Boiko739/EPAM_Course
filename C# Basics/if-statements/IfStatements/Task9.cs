namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            var result = false;

            if (b && ((i < 0 && (i >= -4 || i < -8)) || (i > 0 && (i <= 4 || i > 8))))
            {
                result = true;
            }
            else if (!b && i != 0 && !((i < -4 && i >= -8) || (i >= 4 && i < 8)))
            {
                result = true;
            }

            return result;
        }

        public static bool DoSomething1(bool b, int i)
        {
            bool condition = i > 0;
            i = Math.Abs(i);

            if (b)
            {
                return !((i > 4 && i < 9) || i == 0);
            }
            else
            {
                return condition ?
                    !((i > 3 && i < 8) || i == 0) :
                    !((i > 4 && i < 9) || i == 0);
            }

            // This is the solution I wrote when I did it the first time (almost with no changes)
        }

        public static bool DoSomething3(bool b, int i)
        {
            return (b && ((i < 0 && (i >= -4 || i < -8)) || (i > 0 && (i <= 4 || i > 8)))) ||
                   (!b && i != 0 && !((i < -4 && i >= -8) || (i >= 4 && i < 8)));

            // And I made this solution only now when I saw your option
        }
    }
}
