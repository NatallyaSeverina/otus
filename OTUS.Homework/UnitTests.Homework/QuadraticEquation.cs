using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Homework
{
	public static class QuadraticEquation
	{
		private static double e = 0.000000001;
		public static double[] Solve(double a, double b, double c)
		{
			if (Math.Abs(a) < e
				|| a.CheckIsDoubleValid()
				|| b.CheckIsDoubleValid()
				|| c.CheckIsDoubleValid()
				)
			{
				throw new ArgumentException();
			}
			var d = b*b - 4*a*c;
			if (d < 0)
			{
				return new double[0];
			}
			else if (Math.Abs(d) < e)
			{
				return new double[] { -b /(2 * a), -b / (2 * a) };
			}
			else
			{
				return new double[] { (-b + Math.Sqrt(d))/(2* a), (-b - Math.Sqrt(d)) / (2 * a) };
			}			
		}

		private static bool CheckIsDoubleValid(this double value)
		{
			return value is Double.NaN
				|| value is Double.NegativeInfinity
				|| value is Double.PositiveInfinity;
		}
	}
}
