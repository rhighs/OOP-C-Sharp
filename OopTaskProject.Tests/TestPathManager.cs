using System.Collections.Generic;
using Xunit;
using OopTaskProject.Chris;
using OopTaskProject.Shared.JME3.Items;
using static OopTaskProject.Shared.JME3.Items.Path;

namespace OopTaskProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Node personNode = new Node();
            MainMap map = new MainMap();
            PathManager manager = new PathManager(map, personNode);

            /*
             * Test path. The node shall follow this path.
             */
            var points = new List<Vector3f> {
                new Vector3f(1.0, 1.0, 1.0),
                new Vector3f(2.0, 2.0, 2.0),
                new Vector3f(3.0, 3.0, 3.0),
                new Vector3f(4.0, 4.0, 4.0),
                new Vector3f(5.0, 5.0, 5.0),
                new Vector3f(6.0, 6.0, 6.0),
            };
            var target = new Vector3f(7.0, 7.0, 7.0);
            Path testPath = Path.MakeFrom(points);
            map.supplyNextPath(testPath.Waypoints);
            map.supplyNextTarget(target);

            Assert.False(manager.isPathReady());
            manager.requestNewPath();
            Assert.True(manager.isPathRequested());
            while (!manager.isPathReady())
            {
                ;
            }

            int i = 0;
            Waypoint point;
            while ((point = manager.getWaypoint()) != null && i < points.Count)
            {
                Assert.True(point.Position.Equals(points[i]));
                personNode.setLocalTranslation(point.Position);
                Assert.True(manager.isPositionNear(point));
                i++;
                manager.nextWaypoint();
            }
            // There's still one more point: the target
            Assert.True(point.Position.Equals(target));
            personNode.setLocalTranslation(point.Position);
            Assert.Equal(personNode.getLocalTranslation(), target);
        }
    }
}
