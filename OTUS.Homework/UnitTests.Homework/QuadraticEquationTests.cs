using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests.Homework
{
	public class QuadraticEquationTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Solve_NegativeDiscriminant_ReturnsEmptyArrayWithoutRoots()
		{
			// Arrange x^2+1 = 0 
			var a = 1;
			var b = 0;
			var c = 1;
			
			// Act
			var result = QuadraticEquation.Solve(a, b, c);

			// Assert
			Assert.That(result, Is.Empty);
		}

		[Test]
		public void Solve_PositiveDiscriminant_ReturnsArrayWithTwoDistinctRoots()
		{
			// Arrange D around zero
			var a = 1;
			var b = 0.001;
			var c = 0;
			var expectedRoots = new double[2] {0, -0.001};
			
			// Act

			var result = QuadraticEquation.Solve(a, b, c);
			// Assert
			Assert.IsTrue(result != null && result.Length == 2);
			Assert.AreEqual(expectedRoots, result);
		}

		[Test]
		public void Solve_ZeroDiscriminant_ReturnsArrayWithTwoTheSameRoots()
		{
			// Arrange x^2+2x+1 
			var a = 1;
			var b = 2;
			var c = 1;
			var expectedRoots = new double[2] {-1, -1};
			
			// Act

			var result = QuadraticEquation.Solve(a, b, c);
			// Assert
			Assert.IsTrue(result != null && result.Length == 2 && result[0] == result[1]);
			Assert.AreEqual(expectedRoots, result);
		}

		[Test]
		public void Solve_ZeroAParameter_ThrowException()
		{
			// Arrange  a = 0
			var a = 0;
			var b = 2;
			var c = 1;
					
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => QuadraticEquation.Solve(a, b, c));		
		}

		[Test]
		public void Solve_DoubleNaNAsAParameter_ThrowException()
		{
			// Arrange  a = 0
			var a = Double.NaN;
			var b = 2;
			var c = 1;
					
			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => QuadraticEquation.Solve(a, b, c));		
		}
	}
}