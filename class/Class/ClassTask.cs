using System.Collections.Generic;
using System.Linq;

namespace Class
{
    public class Rectangle
    {
        private double sideA;
        private double sideB;

        public Rectangle(double a, double b)
        {
            sideA = a;
            sideB = b;
        }
        public Rectangle(double a) : this(a, 5) { }
        public Rectangle() : this(4, 3) { }

        public double GetSideA() { return sideA; }
        public double GetSideB() { return sideB; }

        public double Area()
        {
            return sideA * sideB;
        }

        public double Perimeter()
        {
            return 2 * (sideA + sideB);
        }

        public bool IsSquare()
        {
            return sideA == sideB && sideA != 0;
        }

        public void ReplaceSides()
        {
            (sideA, sideB) = (sideB, sideA);
        }
    }

    public class ArrayRectangles
    {
        private readonly Rectangle[] rectangle_array;

        public ArrayRectangles(int n)
        {
            rectangle_array = new Rectangle[n];
        }
        public ArrayRectangles(IEnumerable<Rectangle> rectangles)
        {
            rectangle_array = rectangles.ToArray();
        }
        public ArrayRectangles(Rectangle[] rectangles)
        {
            rectangle_array = rectangles;
        }

        public bool AddRectangle(Rectangle rectangle)
        {
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i] is null)
                {
                    rectangle_array[i] = rectangle;
                    return true;
                }
            }

            return false;
        }

        public int NumberMaxArea()
        {
            int max = 0;
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Area() > rectangle_array[max].Area())
                {
                    max = i;
                }
            }

            return max;
        }

        public int NumberMinPerimeter()
        {
            int min = 0;
            for (int i = 1; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].Perimeter() < rectangle_array[min].Perimeter())
                {
                    min = i;
                }
            }

            return min;
        }

        public int NumberSquare()
        {
            int number = 0;
            for (int i = 0; i < rectangle_array.Length; i++)
            {
                if (rectangle_array[i].IsSquare())
                {
                    number++;
                }
            }

            return number;
        }
    }
}
