namespace OopTaskProject.Shared
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

        public int distance(Vector3f other)
        {
            return 0;
        }
    }
}
