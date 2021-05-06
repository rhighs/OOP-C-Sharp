using System;
using System.Collections;
using System.Collections.Generic;
using OopTaskProject.Shared;
using static OopTaskProject.Shared.Path;

namespace OopTaskProject.Chris
{
    /*
     * This version of the PathFinder simply computes a path using random numbers.
     * This is because we don't have any navmesh, so might as well use a random
     * path.
     */
    public class PathFinder : IPathFinder
    {
        //private const string NAVMESH_NAME = "NavMesh";
        //private NavMesh navmesh;
        //private NavMeshPathFinder pathFinder;
        private Random rng;
        private Node scene;
        private IList<Path.Waypoint> path = null;

        public PathFinder(Node scene)
        {
            rng = new Random();
            this.scene = scene;
            //Node child = scene.getChild(NAVMESH_NAME);
            //Mesh mesh  = child.getMesh();
            //navmesh = new NavMesh(mesh);
            //pathFinder = new NavMeshPathFinder(navmesh);
        }

        public void supplyPath(IList<Path.Waypoint> path)
        {
            this.path = path;
        }

        public IList<Path.Waypoint> getPath(Vector3f start, Vector3f target)
        {
            if (path != null)
            {
                var tmp = path;
                path = null;
                tmp.Add(new Waypoint(target));
                return tmp;
            }
            return Path.MakeRandom(rng).Waypoints;
        }

        public Vector3f getRandomPoint()
        {
            return Vector3f.MakeRandom(rng, 10.0);
            //int i = rnd.Next(navmesh.Cells.Count);
            //return new Vector3f(navmesh.Cells[i].getRandomPoint());
        }
    }
}

