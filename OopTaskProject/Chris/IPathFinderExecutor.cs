using System.Collections.Generic;
using System.Threading.Tasks;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Chris
{
    public interface IPathFinderExecutor
    {
        /**
         * @param currentPos current position of the entity
         * @return a Future which will contain a list of waypoint obtained by a PathGeneratorCall
         */
        public Task<IList<Path.Waypoint>> request(Vector3F currentPos);

        /**
         * Shutdown the thread pool. No more requests can be made after execution
         * of this function.
         */
        public void shutdown();
    }
}

