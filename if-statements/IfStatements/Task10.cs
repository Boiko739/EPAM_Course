﻿namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            bool trueTrue = b1 && b2;
            bool trueFalse = b1 && !b2;
            bool falseTrue = !b1 && b2;

            if (trueTrue)
            {
                if (i > 1 && i < 10)
                {
                    return 10 - i;
                }
                else if (i < -1 && i > -10)
                {
                    return i + 5;
                }
                else if (i == 0)
                {
                    return -1;
                }
            }
            else if (trueFalse)
            {
                if (i > 1 && i < 10)
                {
                    return i + 10;
                }
                else if (i < -1 && i > -10)
                {
                    return 5 - i;
                }
                else if (i == 0)
                {
                    return -1;
                }
            }
            else if (falseTrue)
            {
                if (i % 10 == 0)
                {
                    return i + 1;
                }
                else if ((i > 0 && i < 5) || (i < 0 && i > -5))
                {
                    return i + 10;
                }
            }
            else
            {
                if (i % 10 == 0)
                {
                    return i - 1;
                }
                else if ((i > 0 && i < 5) || (i < 0 && i > -5))
                {
                    return i - 10;
                }
            }

            return i;
        }
    }
}
