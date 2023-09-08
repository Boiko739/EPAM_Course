namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            // My second option
            bool trueTrue = b1 && b2;
            bool trueFalse = b1 && !b2;
            bool falseTrue = !b1 && b2;

            if (trueTrue || trueFalse)
            {
                if (i > -5 && i <= 5)
                {
                    return trueTrue ? i * -2 : i * i;
                }
                else
                {
                    return trueTrue ? 10 - (i * 2) : i * i * i;
                }
            }
            else
            {
                if (i < -9 || i > 7)
                {
                    return -i;
                }
                else if (falseTrue && i >= -7 && i < -3)
                {
                    return i * 10;
                }
                else if (!falseTrue && i >= -3 && i < 5)
                {
                    return i * -100;
                }

                return i;
            }
        }

        public static int DoSomething1(bool b1, bool b2, int i)
        {
            // My first option
            bool trueTrue = b1 && b2;
            bool trueFalse = b1 && !b2;
            bool falseTrue = !b1 && b2;

            if (i == 0)
            {
                return i;
            }
            else if (trueTrue)
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
            else if (trueFalse)
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
            else if (falseTrue)
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
            else
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
