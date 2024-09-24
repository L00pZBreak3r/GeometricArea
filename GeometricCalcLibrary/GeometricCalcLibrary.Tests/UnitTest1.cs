using System;
using Xunit;
using GeometricCalcLibrary.GeometricShapes;

namespace GeometricCalcLibrary.Tests
{
	public class UnitTest1
	{
        private const int mTestCount = 102400;
        private const double mEpsilon = 0.0001;
        private static readonly Random mRand = new Random();
        
        protected static double GetRandomDouble(double aMaximum = 1.0)
        {
            return mRand.NextDouble() * aMaximum;
        }

        protected static bool DoubleValuesAreEqual(double aValue1, double aValue2)
        {
            return Math.Abs(aValue1 - aValue2) < mEpsilon;
        }

		[Fact]
		public void TestCircle()
		{
            bool aCorrect = true;
            for (int i = 0; (i < mTestCount) && aCorrect; i++)
            {
                double aRadius = GetRandomDouble();
                var aShape = new Circle()
                {
                    Radius = aRadius
                };

                double aArea = aRadius * 2 * Math.PI;
                aCorrect = DoubleValuesAreEqual(aShape.GetArea(), aArea);
            }
			Assert.True(aCorrect);
		}

		[Fact]
		public void TestCircleException()
		{
            var aShape = new Circle();

            Assert.Throws<ArgumentOutOfRangeException>(() => aShape.Radius = -1);
		}

		[Fact]
		public void TestTriangle()
		{
            bool aCorrect = true;
            for (int i = 0; (i < mTestCount) && aCorrect; i++)
            {
                double aA = GetRandomDouble();
                double aB = GetRandomDouble();
                double aC = (aA + aB) * GetRandomDouble();
                var aShape = new Triangle()
                {
                    A = aA,
                    B = aB,
                    C = aC
                };

                if (aShape.Exists)
                {
                    var aSemiPerimeter = (aA + aB + aC) / 2;
                    double aArea = Math.Sqrt(aSemiPerimeter * (aSemiPerimeter - aA) * (aSemiPerimeter - aB) * (aSemiPerimeter - aC));
                    aCorrect = DoubleValuesAreEqual(aShape.GetArea(), aArea);
                }
            }
			Assert.True(aCorrect);
		}

		[Fact]
		public void TestTriangleIsRightAngled()
		{
            bool aCorrect = true;
            for (int i = 0; (i < mTestCount) && aCorrect; i++)
            {
                double aA = GetRandomDouble();
                double aB = GetRandomDouble();
                double aC = Math.Sqrt(aA * aA + aB * aB);
                var aShape = new Triangle()
                {
                    A = aA,
                    B = aB,
                    C = aC
                };

                aCorrect = aShape.IsRightAngled;
            }
			Assert.True(aCorrect);
		}

		[Fact]
		public void TestTriangleException()
		{
            var aShape = new Triangle();

            Assert.Throws<ArgumentOutOfRangeException>(() => aShape.A = -1);
		}

		[Fact]
		public void TestRectangle()
		{
            bool aCorrect = true;
            for (int i = 0; (i < mTestCount) && aCorrect; i++)
            {
                double aA = GetRandomDouble();
                double aB = GetRandomDouble();
                var aShape = new Rectangle()
                {
                    A = aA,
                    B = aB
                };

                double aArea = aA * aB;
                aCorrect = DoubleValuesAreEqual(aShape.GetArea(), aArea);
            }
			Assert.True(aCorrect);
		}

		[Fact]
		public void TestRectangleException()
		{
            var aShape = new Rectangle();

            Assert.Throws<ArgumentOutOfRangeException>(() => aShape.A = -1);
		}
	}
}
