using System;

namespace DartsGame
{
    public static class Darts
    {
        /// <summary>
        /// Calculates the earned points in a single toss of a Darts game.
        /// </summary>
        /// <param name="x">x-coordinate of dart.</param>
        /// <param name="y">y-coordinate of dart.</param>
        /// <returns>The earned points.</returns>
        public static int GetScore(double x, double y)
        {
            int score = 0;
            (double xDistance, double yDistance) = (Math.Abs(x), Math.Abs(y));
            double distance = Math.Sqrt((xDistance * xDistance) + (yDistance * yDistance));
            if (distance <= 1)
            {
                score = 10;
            }
            else if (distance <= 5)
            {
                score = 5;
            }
            else if (distance <= 10)
            {
                score = 1;
            }

            return score;
        }
    }
}
