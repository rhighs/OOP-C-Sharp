using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OopTaskProject.Chris
{
    public class PathFinderExecutor : IPathFinderExecutor
    {
        private Node scene;

        public PathFinderExecutor(Node scene)
        {
            this.scene = scene;
        }

        public Task<IList<Path.Waypoint>> request(Vector3f currentPos)
        {
            var res = Task.Run(() =>
                    {
                        PathFinder pf = new PathFinder(scene);
                        return pf.getPath(currentPos, pf.getRandomPoint());
                    });
            return res;
        }

        public void shutdown()
        {

        }
    }
}

