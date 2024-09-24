using System;
using System.Runtime.CompilerServices;

namespace GeometricCalcLibrary
{
    public abstract class GeometricShape
    {
        protected GeometricShape(string aName)
        {
            if (string.IsNullOrWhiteSpace(aName))
                throw new ArgumentOutOfRangeException(nameof(Name), nameof(Name) + " cannot be empty");

            Name = aName;
        }

        public string Name { get; }

        public abstract double GetArea();

        protected static void ThrowIfNegative(double aValue, [CallerMemberName] string? aPropertyName = null)
        {
            if (aValue < 0.0)
                throw new ArgumentOutOfRangeException(aPropertyName, $"{aPropertyName} cannot be negative");
        }
    }
}
