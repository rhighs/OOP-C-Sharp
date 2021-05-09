using System;
using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class Path
    {
        public class Waypoint
        {
            public Vector3F Position { get; private set; }

            public Waypoint()
            {

            }

            public Waypoint(Vector3F pos)
            {
                Position = pos;
            }
        }

        public List<Waypoint> Waypoints { get; private set; }

        public Path()
        {
            Waypoints = new List<Waypoint>();
        }

        public static Path MakeRandom(Random rng)
        {
            Path path = new Path();
            for (int i = 0; i < 10; i++)
            {
                path.Waypoints.Add(
                    new Waypoint(Vector3F.MakeRandom(rng, 10.0))
                );
            }
            return path;
        }

        public static Path MakeFrom(List<Vector3F> vecs)
        {
            Path path = new Path();
            foreach (var v in vecs)
            {
                path.Waypoints.Add(new Waypoint(v));
            }
            return path;
        }
    }
}

