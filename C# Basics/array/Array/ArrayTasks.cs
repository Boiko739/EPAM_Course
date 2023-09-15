namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            int halfOfArray = nums.Length / 2;
            for (int i = 0; i < halfOfArray; i++)
            {
                if (nums[i] % 2 == 0 && nums[^(i + 1)] % 2 == 0)
                {
                    (nums[i], nums[^(i + 1)]) = (nums[^(i + 1)], nums[i]);
                }
            }
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int firstMax = 0;
            int lastMax = nums.Length - 1;
            if (nums.Length < 2)
            {
                return 0;
            }
            else
            {
                for (int i = firstMax; i < nums.Length; i++)
                {
                    if (nums[i] > nums[firstMax])
                    {
                        firstMax = i;
                    }
                }

                for (int i = lastMax; i > 0; i--)
                {
                    if (nums[i] > nums[lastMax])
                    {
                        lastMax = i;
                    }
                }

                return lastMax - firstMax;
            }

        }

        /// <summary>
        /// Task 3 
        /// </summary>
        public static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    matrix[i, j] = 0;
                }

                for (int j = matrix.GetLength(1) - 1; j > i; j--)
                {
                    matrix[i, j] = 1;
                }
            }
        }
    }
}
