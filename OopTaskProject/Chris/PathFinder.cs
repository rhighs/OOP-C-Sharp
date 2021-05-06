using System;
using System.Collections;
using System.Collections.Generic;
using OopTaskProject.Shared;

namespace OopTaskProject.Chris
{
    public class PathFinder : IPathFinder
    {
        private const string NAVMESH_NAME = "NavMesh";
        private NavMesh navmesh;
        private NavMeshPathFinder pathFinder;
        private Random rnd;

        public PathFinder(Node scene)
        {
            rnd = new Random();
            Node child = scene.getChild(NAVMESH_NAME);
            Mesh mesh  = child.getMesh();
            navmesh = new NavMesh(mesh);
            pathFinder = new NavMeshPathFinder(navmesh);
        }

        public IList<Path.Waypoint> getPath(Vector3f start, Vector3f target)
        {
            pathFinder.clearPath();
            pathFinder.setPosition(start);
            bool success = pathFinder.computePath(target);
            return success ? pathFinder.PathResult.Waypoints : new List<Path.Waypoint>();
        }

        public Vector3f getRandomPoint()
        {
            int i = rnd.Next(navmesh.Cells.Count);
            return new Vector3f(navmesh.Cells[i].getRandomPoint());
        }
    }
}

