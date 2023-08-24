namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething1(bool b, int i)
        {
            var result = false;

            if (b)
            {
                if ((i >= -3 && i < 0) || i < -6)
                {
                    result = true;
                }
                else if ((i <= 3 && i > 0) || i > 6)
                {
                    result |= true;
                }
            }
            else
            {
                result = true;
                if (i == 0)
                {
                    result = false;
                }
                else if ((i <= -3 && i >= -6) || (i >= 3 && i <= 6))
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool DoSomething(bool b, int i)
        {
            i = Math.Abs(i);
            return b ?
                !((i > 3 && i < 7) || i == 0) :
                !((i > 2 && i < 7) || i == 0);
        }

        // I'm so proud of myself for finding such a solution
    }
}
