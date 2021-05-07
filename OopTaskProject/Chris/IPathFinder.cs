using System.Collections.Generic;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Chris
{
    public interface IPathFinder
    {
        /**
         * Asks a new path, from start to target, to the jme3.ai path finder
         *
         * @param start the starting point of our path
         * @param target the ending point of our path
         * @return a list of waypoint going trough the navigation mesh in case of success,
         * an empty list otherwise
         */
        IList<Path.Waypoint> getPath(Vector3f start, Vector3f target);

        /**
         * @return a random 3d point inside the navmesh,
         * so we are sure it is somehow reachable by the entities
         */
        Vector3f getRandomPoint();
    }
}

