using System;

namespace GeometricCalcLibrary.GeometricShapes
{
    public class Circle : GeometricShape
    {
        public Circle()
            : base(nameof(Circle))
        {
        }

        protected double mRadius;
        public double Radius
        {
            get => mRadius;
            set
            {
                ThrowIfNegative(value);
                mRadius = value;
            }
        }

        public override double GetArea()
        {
            return Radius * 2 * Math.PI;
        }
    }
}
