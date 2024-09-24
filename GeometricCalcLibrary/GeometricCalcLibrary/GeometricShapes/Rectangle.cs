using System;

namespace GeometricCalcLibrary.GeometricShapes
{
    public class Rectangle : GeometricShape
    {
        public Rectangle()
            : base(nameof(Rectangle))
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

        public override double GetArea()
        {
            return A * B;
        }
    }
}
