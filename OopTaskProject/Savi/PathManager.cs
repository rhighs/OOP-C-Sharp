using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Savi
{
    public class PathManager : IPathManager
    {
        private readonly IList<Path.Waypoint> _path;

        public PathManager()
        {
            _path = new List<Path.Waypoint>();
        }

        public Path.Waypoint LastWaypoint => _path.FirstOrDefault();

        public Task RequestNewPath()
        {
            _path.Clear();

            foreach (var _ in new Path.Waypoint[20])
                _path.Add(new Path.Waypoint());

            // Simulating a request that can take some time...
            Task.Delay(TimeSpan.FromSeconds(1.5));

            return Task.CompletedTask;
        }

        public void SetPosition(Path.Waypoint position)
        {
            // nothing to do... we are not in the real world...
        }

        public bool IsNear(Path.Waypoint position)
        {
            if (position is null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            if (LastWaypoint is null)
            {
                throw new InvalidOperationException($"Invalid call to {nameof(IsNear)}, no path is available.");
            }

            return _path.Count == 1;
        }

        public void NextWaypoint()
        {
            _path.RemoveAt(1);
        }
    }
}