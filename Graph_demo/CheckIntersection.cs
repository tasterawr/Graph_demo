using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graph_demo
{
    public static class CheckIntersection
    {
		public static int Area(Point a, Point b, Point c)
		{
			return (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
		}

		public static bool Intersect_1(int a, int b, int c, int d)
		{
			if (a > b)
			{
				int temp = a;
				a = b;
				b = temp;
			}
			if (c > d)
			{
				int temp = c;
				c = d;
				d = temp;
			}
			return (a > c ? a : c) <= (b > d ? b : d);
		}

		public static bool Intersect(Point a, Point b, Point c, Point d)
		{
			return Intersect_1(a.X, b.X, c.X, d.X)
				&& Intersect_1(a.Y, b.Y, c.Y, d.Y)
				&& Area(a, b, c) * Area(a, b, d) <= 0
				&& Area(c, d, a) * Area(c, d, b) <= 0;
		}
	}
}
