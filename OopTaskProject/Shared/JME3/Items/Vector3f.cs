using System;
using System.Globalization;

namespace OopTaskProject.Shared.JME3.Items
{
    public class Vector3F
    {
        public double X { get; set; }
        
        public double Y { get; set; }
        
        public double Z { get; set; }

        public Vector3F()
        {
        }

        public Vector3F(Vector3F v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public Vector3F(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int Distance(Vector3F other)
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{X.ToString(CultureInfo.CurrentCulture)}, " +
                   $"{Y.ToString(CultureInfo.CurrentCulture)}, " +
                   $"{Z.ToString(CultureInfo.CurrentCulture)}";
        }

        public static Vector3F MakeRandom(Random rng, double scale)
        {
            return new(
                rng.NextDouble() * scale,
                rng.NextDouble() * scale,
                rng.NextDouble() * scale
            );
        }

        private bool Equals(Vector3F other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Vector3F) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
}