using System.Threading.Tasks;

namespace OopTaskProject.Savi
{
    /// <summary>
    /// The component movement handler called from the context.
    /// </summary>
    public interface IMovementHandler
    {
        /// <summary>
        /// When invoked updates component movement.
        /// </summary>
        Task UpdateAsync();
    }
}