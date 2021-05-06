using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using OopTaskProject.Shared;
using static OopTaskProject.Shared.Path;

namespace OopTaskProject.Chris
{
    public class PathManager : IPathManager
    {
        private PathFinderExecutor pathCalculator;
        private Spatial personSpatial;
        private bool isRequested = false;
        private Task<IList<Waypoint>> nextPathFuture;
        private int currPointIndex = 0;
        private IList<Waypoint> waypoints;

        /**
         * When invoked create a new instance of the path manager implementation.
         *
         * @param map     The map.
         * @param spatial The spatial instance.
         */
        public PathManager(MainMap map, Spatial personSpatial)
        {
            this.personSpatial = personSpatial;
            this.pathCalculator = map.createPathFinderExecutor();
        }

        public Waypoint getWaypoint()
        {
            if (waypoints == null) {
                if (!isPathReady()) {
                    return null;
                }
                waypoints = nextPathFuture.Result;
                nextPathFuture = null;
                isRequested = false;
                currPointIndex = 0;
            }
            if (currPointIndex > waypoints.Count() - 1) {
                waypoints = null;
                return null;
            }
            return waypoints[currPointIndex];
        }

        public void requestNewPath()
        {
            nextPathFuture = pathCalculator.request(personSpatial.getLocalTranslation());
            isRequested = true;
        }

        public void setPosition(Waypoint waypoint)
        {
            /*
            if (waypoint == null)
            {
                return;
            }
            Vector3f v = waypoint.Position - personSpatial.getLocalTranslation();
            */
        }

        public bool isPositionNear(Waypoint waypoint)
        {
            if (waypoint == null)
            {
                return true;
            }
            return personSpatial.getLocalTranslation().distance(waypoint.Position) <= 1;
        }

        public bool isPathReady()
        {
            if (!isRequested)
            {
                return false;
            }
            return nextPathFuture.IsCompleted;
        }

        public bool isPathRequested()
        {
            return isRequested;
        }

        public void nextWaypoint()
        {
            currPointIndex++;
        }
    }
}

