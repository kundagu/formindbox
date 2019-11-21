using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    public class Area
    {
        public static double CircleArea(double radius) => radius > 0 ? radius * radius * Math.PI : throw new ArgumentOutOfRangeException();

        public static double TriangleArea(params double[] sides)
        {
            if (sides.Length != 3) throw new ArgumentException();
            double p = 0.0d;
            foreach (var side in sides)
                if (side > 0 && side*2<sides.Sum()) p += side; else  throw new ArgumentOutOfRangeException();
            p /= 2d;
            double area = p;
            foreach (var side in sides) area *= (p - side);
            return Math.Sqrt(area);
        }

        public static bool IsRectangular(params double[] sides)
        {
            if (sides.Length != 3) throw new ArgumentException();
            foreach (var side in sides) if (side * 2 >= sides.Sum()) throw new ArgumentOutOfRangeException();
            int h = 0;
            var cat = new List<int>();
            for (int i = 1; i < 3; i++)
            {
                if (sides[i] <0) throw new ArgumentOutOfRangeException();
                if (i == 0) continue;
                if (sides[h] <= sides[i])
                {
                    cat.Add(h);
                    h = i;
                }
                else cat.Add(i);
            }
            double squareCat = sides[cat[0]] * sides[cat[0]] + sides[cat[1]] * sides[cat[1]];
            return Math.Abs(Math.Sqrt(squareCat) - sides[h]) < 0.000001;
        }
    }
}
