using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Chris
{
    public class PathFinderExecutor : IPathFinderExecutor
    {
        private Node scene;
        private IList<Path.Waypoint> nextPath = null;
        private Vector3f nextTarget = null;

        public PathFinderExecutor(Node scene)
        {
            this.scene = scene;
        }

        public Task<IList<Path.Waypoint>> request(Vector3f currentPos)
        {
            var res = Task.Run(() =>
                    {
                        Thread.Sleep(5000);
                        PathFinder pf = new PathFinder(scene);
                        if (nextPath != null)
                        {
                            pf.supplyPath(nextPath);
                            nextPath = null;
                        }
                        if (nextTarget != null)
                        {
                            var tmp = nextTarget;
                            nextTarget = null;
                            return pf.getPath(currentPos, tmp);
                        }
                        return pf.getPath(currentPos, pf.getRandomPoint());
                    });
            return res;
        }

        public void shutdown()
        {

        }

        public void supplyNextPath(IList<Path.Waypoint> path)
        {
            this.nextPath = path;
        }

        public void supplyTarget(Vector3f point)
        {
            this.nextTarget = point;
        }
    }
}

