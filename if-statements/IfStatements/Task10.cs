namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            var result = i;
            if (b1)
            {
                if (i == 0)
                {
                    result = -1;
                }
                else if (i >= 2 && i <= 9)
                {
                    if (b2)
                    {
                        result = 10 - result;
                    }
                    else
                    {
                        result += 10;
                    }
                }
                else if (i <= -2 && i >= -9)
                {
                    if (b2)
                    {
                        result += 5;
                    }
                    else
                    {
                        result = 5 - result;
                    }
                }
            }
            else
            {
                if (i == 0)
                {
                    if (b2)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = -1;
                    }
                }
                else if (b2)
                {
                    if (i <= -10 || i >= 10)
                    {
                        result += 1;
                    }
                }
                else if (i <= -10 || i >= 10)
                {
                    result -= 1;
                }

                if (i != 0 && i > -5 && i < 5)
                {
                    if (b2)
                    {
                        result += 10;
                    }
                    else
                    {
                        result -= 10;
                    }
                }
            }

            return result;
        }

        public static int DoSomething1(bool b1, bool b2, int i)
        {
            // My option
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
