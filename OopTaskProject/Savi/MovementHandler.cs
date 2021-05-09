using System.Threading.Tasks;

namespace OopTaskProject.Savi
{
    public class MovementHandler : IMovementHandler
    {
        private readonly IPathManager _pathManager;

        private readonly IStuckManager _stuckManager;

        /// <summary>
        /// Creates a new instance of the movement handler.
        /// </summary>
        /// <param name="pathManager">The path manager.</param>
        /// <param name="stuckManager">The stuck manager.</param>
        public MovementHandler(IPathManager pathManager, IStuckManager stuckManager)
        {
            _pathManager = pathManager;
            _stuckManager = stuckManager;
        }

        public Task UpdateAsync()
        {
            if (_pathManager.LastWaypoint is null || _stuckManager.IsStuck)
            {
                var newPathTask = _pathManager.RequestNewPath();

                if (_stuckManager.IsStuck)
                {
                    _stuckManager.Reset();
                }

                return newPathTask; // returning the request task, the context will await this
            }

            var isNear = _pathManager.IsNear(_pathManager.LastWaypoint);

            _pathManager.SetPosition(isNear ? null : _pathManager.LastWaypoint);

            if (!isNear) return Task.CompletedTask;

            _pathManager.NextWaypoint();
            _stuckManager.Toggle();

            return Task.CompletedTask;
        }
    }
}