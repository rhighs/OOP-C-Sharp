using System;
using System.Collections;
using System.Collections.Generic;

namespace OopTaskProject.Chris
{
    public class Path
    {
        public class Waypoint
        {
            public Vector3f Position { get; private set; }
        }

        public List<Waypoint> Waypoints { get; private set; }
    }
}

