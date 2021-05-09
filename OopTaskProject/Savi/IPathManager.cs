using System;
using System.Threading.Tasks;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Savi
{
    /// <summary>
    /// The path manager handles the generation of the path and the movement of the component.
    /// </summary>
    public interface IPathManager
    {
        /// <summary>
        /// When invoked returns the last waypoint (null if not available).
        /// </summary>
        Path.Waypoint LastWaypoint { get; }

        /// <summary>
        /// Requests a new path.
        /// </summary>
        /// <returns>The request task.</returns>
        Task RequestNewPath();

        /// <summary>
        /// Sets a new position for the component.
        /// </summary>
        /// <param name="position">The new position, null if the component should be in the same position.</param>
        void SetPosition(Path.Waypoint position);

        /// <summary>
        /// Sets a new position for the component.
        /// </summary>
        /// <param name="position">The position you want to compare.</param>
        /// <returns>True if is near, false otherwise.</returns>
        /// <exception cref="ArgumentNullException">When <paramref name="position"/> is null.</exception>
        /// <exception cref="InvalidOperationException">When no waypoint is available to compare.</exception>
        bool IsNear(Path.Waypoint position);

        /// <summary>
        /// Skips the current waypoint.
        /// </summary>
        /// <exception cref="InvalidOperationException">When no path is available.</exception>
        void NextWaypoint();
    }
}