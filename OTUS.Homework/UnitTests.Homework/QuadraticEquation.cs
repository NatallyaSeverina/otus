using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Homework
{
	public static class QuadraticEquation
	{
		public static double[] Solve(double a, double b, double c)
		{
			if (Math.Abs(a) < 0.000000001
				|| a is Double.NaN
				|| a is Double.NegativeInfinity
				|| a is Double.PositiveInfinity
				|| b is Double.NaN
				|| b is Double.NegativeInfinity
				|| b is Double.PositiveInfinity
				|| c is Double.NaN
				|| c is Double.NegativeInfinity
				|| c is Double.PositiveInfinity)
			{
				throw new ArgumentException();
			}
			var d = b*b - 4*a*c;
			if (d < 0)
			{
				return new double[0];
			}
			else if (Math.Abs(d) < 0.000000001)
			{
				return new double[] { -b /(2 * a), -b / (2 * a) };
			}
			else if (d > 0 )
			{
				return new double[] { (-b + Math.Sqrt(d))/(2* a), (-b - Math.Sqrt(d)) / (2 * a) };
			}
			return new double[0];
		}
	}
}
