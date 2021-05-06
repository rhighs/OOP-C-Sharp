using System;
using OopTaskProject.Shared;

namespace OopTaskProject.Chris
{
    public class MainMap : IMainMap
    {
        private const string SCENE_NAME = "SimulationScene";
        private const string NAVMESH_NAME = "NavMesh";
        private Node scene;
        private PathFinderExecutor pathFinder;

        public MainMap()
        {
            scene = new Node();
            scene.Name = SCENE_NAME;
            pathFinder = new PathFinderExecutor(scene);
        }

        public NavMesh getNavMesh()
        {
            Node child = scene.getChild(NAVMESH_NAME);
            Mesh mesh  = child.getMesh();
            return new NavMesh(mesh);
        }

        public PathFinderExecutor createPathFinderExecutor()
        {
            return pathFinder;
        }

        public PathFinder createPathFinder()
        {
            return new PathFinder(scene);
        }

        public void shutdown()
        {
            pathFinder.shutdown();
        }
    }
}
