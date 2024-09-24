using System;

namespace GeometricCalcLibrary.GeometricShapes
{
    public class Triangle : GeometricShape
    {
        protected const double mEpsilon = 0.0001;

        public Triangle()
            : base(nameof(Triangle))
        {
        }

        protected double mA;
        public double A
        {
            get => mA;
            set
            {
                ThrowIfNegative(value);
                mA = value;
            }
        }

        protected double mB;
        public double B
        {
            get => mB;
            set
            {
                ThrowIfNegative(value);
                mB = value;
            }
        }

        protected double mC;
        public double C
        {
            get => mC;
            set
            {
                ThrowIfNegative(value);
                mC = value;
            }
        }

        public bool Exists
        {
            get
            {
                double aMaxSide = A;
                double aSum = B + C;
                if (aMaxSide < B)
                {
                    aMaxSide = B;
                    aSum = A + C;
                }
                if (aMaxSide < C)
                {
                    aMaxSide = C;
                    aSum = A + B;
                }
                return aMaxSide < aSum;
            }
        }

        public bool IsRightAngled =>
            (C > 0) && (Math.Abs(1-(A*A+B*B)/(C*C)) < mEpsilon) ||
            (A > 0) && (Math.Abs(1-(B*B+C*C)/(A*A)) < mEpsilon) ||
            (B > 0) && (Math.Abs(1-(C*C+A*A)/(B*B)) < mEpsilon);

        public override double GetArea()
        {
            var aSemiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(aSemiPerimeter * (aSemiPerimeter - A) * (aSemiPerimeter - B) * (aSemiPerimeter - C));
        }
    }
}
