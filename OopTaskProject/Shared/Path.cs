using System;
using System.Collections;
using System.Collections.Generic;

namespace OopTaskProject.Shared
{
    public class Path
    {
        public class Waypoint
        {
            public Vector3f Position { get; private set; }

            public Waypoint()
            {

            }

            public Waypoint(Vector3f pos)
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
                    new Waypoint(Vector3f.MakeRandom(rng, 10.0))
                );
            }
            return path;
        }

        public static Path MakeFrom(List<Vector3f> vecs)
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

