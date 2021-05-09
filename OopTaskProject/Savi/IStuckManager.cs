namespace OopTaskProject.Savi
{
    /// <summary>
    /// The stuck manager checks if the component is stuck in the world.
    /// </summary>
    public interface IStuckManager
    {
        /// <summary>
        /// If the component is stuck.
        /// </summary>
        bool IsStuck { get; }

        /// <summary>
        /// Starts the checks if not already started.
        /// </summary>
        void Toggle();

        /// <summary>
        /// Resets the checks.
        /// </summary>
        void Reset();
    }
}