namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2 && i == 0)
            {
                return 1;
            }
            else if (b1 && !b2 && i == 0)
            {
                return -1;
            }
            else if (b1 && b2 && i >= 4 && i < 8)
            {
                return i * 2;
            }
            else if (b1 && !b2 && i > 3 && i <= 7)
            {
                return 10 - (i * 2);
            }
            else if (b1 && b2 && i < -4 && i >= -8)
            {
                return i * 3;
            }
            else if (b1 && !b2 && i <= -3 && i > -7)
            {
                return 10 + (i * 3);
            }
            else if (!b1 && i == 0)
            {
                return 1;
            }
            else if (!b1 && b2 && (i < -8 || i >= 8))
            {
                return i - (i * i);
            }
            else if (!b1 && !b2 && (i <= -7 || i > 7))
            {
                return i - (i * i * i);
            }
            else if (!b1 && b2 && i != 0 && i > -4 && i <= 4)
            {
                return (i * i) - (i * i * i);
            }
            else if (!b1 && !b2 && i != 0 && i >= -3 && i < 3)
            {
                return (i * i * i) - (i * i);
            }
            else
            {
                return i;
            }
        }

        public static int DoSomething1(bool b1, bool b2, int i)
        {
            // My option
            bool trueTrue = b1 && b2;
            bool trueFalse = b1 && !b2;
            bool falseTrue = !b1 && b2;

            if (i == 0)
            {
                return trueFalse ? -1 : 1;
            }
            else if (trueTrue)
            {
                if (i > 3 && i < 8)
                {
                    return i * 2;
                }
                else if (i < -4 && i > -9)
                {
                    return i * 3;
                }
            }
            else if (trueFalse)
            {
                if (i > 3 && i < 8)
                {
                    return (5 - i) * 2;
                }
                else if (i < -2 && i > -7)
                {
                    return ((3 + i) * 3) + 1;
                }
            }
            else if (falseTrue)
            {
                if (i > -4 && i < 5)
                {
                    return -i * (i - 1) * i;
                }
                else if (i < -8 || i > 7)
                {
                    return -i * (i - 1);
                }
            }
            else
            {
                if (i > -4 && i < 3)
                {
                    return i * (i - 1) * i;
                }
                else if (i < -6 || i > 7)
                {
                    return (-i * (i - 1) * i) + ((i - 1) * -i);
                }
            }

            return i;
        }
    }
}
