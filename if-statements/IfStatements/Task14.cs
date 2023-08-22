namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (i == 0)
            {
                return i;
            }

            if (b1 && b2)
            {
                if (i > -5)
                {
                    return -(i % 5) * 2 == 0 ? -10 : -(i % 5) * 2;
                }
                else
                {
                    return (-(i % 5) * 2) - ((i / 5) * 10) + 10;
                }
            }
            else if (b1 && !b2)
            {
                if (i > -5 && i < 6)
                {
                    return i * i;
                }
                else
                {
                    return i * i * i;
                }
            }
            else if (!b1 && b2)
            {
                if (i > -8 && i < -3)
                {
                    return i * 10;
                }
                else if (i < -9 || i > 7)
                {
                    return -i;
                }
            }
            else if (!b1 && !b2)
            {
                if (i > -4 && i < 5)
                {
                    return i * -100;
                }
                else if (i < -9 || i > 7)
                {
                    return -i;
                }
            }

            return i;
        }
    }
}
