namespace IfStatements
{
    public static class Task11
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2)
            {
                if (i > 3 && i < 8)
                {
                    return i * 2;
                }
                else if (i < -4 && i > -9)
                {
                    return i * 3;
                }
                else if (i == 0)
                {
                    return 1;
                }
            }
            else if (b1 && !b2)
            {
                if (i > 3 && i < 8)
                {
                    return (5 - i) * 2;
                }
                else if (i < -2 && i > -7)
                {
                    return ((3 + i) * 3) + 1;
                }
                else if (i == 0)
                {
                    return -1;
                }
            }
            else if (!b1 && b2)
            {
                if (i == 0)
                {
                    return 1;
                }
                else if (i > -4 && i < 5)
                {
                    return -i * (i - 1) * i;
                }
                else if (i < -8 || i > 7)
                {
                    return -i * (i - 1);
                }
            }
            else if (!b1 && !b2)
            {
                if (i == 0)
                {
                    return 1;
                }
                else if (i > -4 && i < 3)
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
