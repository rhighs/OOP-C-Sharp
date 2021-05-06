using OopTaskProject.Shared;

namespace OopTaskProject.Chris
{
    interface IMainMap
    {
        /**
         * @return a navigation mesh, extracted from the scene
         */
        NavMesh getNavMesh();

        /**
         * @return an instance of path finder executor
         */
        PathFinderExecutor createPathFinderExecutor();

        /**
         * @return an instance of path finder
         */
        PathFinder createPathFinder();

        /**
         * Shutdown the shared path finder.
         */
        void shutdown();
    }
}
