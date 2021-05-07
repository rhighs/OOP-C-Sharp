using System;

namespace OopTaskProject.Shared.JME3.Items
{
    public class Vector3f
    {
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;
        public double Z { get; set; } = 0.0;

        public Vector3f()
        {

        }

        public Vector3f(Vector3f v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
        }

        public Vector3f(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public int distance(Vector3f other)
        {
            return 0;
        }

        public override string ToString()
        {
            return X.ToString() + ", " + Y.ToString() + ", " + Z.ToString();
        }

        public static Vector3f MakeRandom(Random rng, double scale)
        {
            return new Vector3f(
                rng.NextDouble() * scale,
                rng.NextDouble() * scale,
                rng.NextDouble() * scale
            );
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Vector3f))
            {
                return false;
            }
            Vector3f vec = (Vector3f) obj;
            return vec.X == X
                && vec.Y == Y
                && vec.Z == Z;
        }
    }
}
