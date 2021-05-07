using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public interface ISimulationCamera
    {

        public Vector3f Location { get; } 

        public Vector3f Direction { get; }

        public void update();

        public void AttachToEntity(Entity entity);

        public void DetachEntity();

    }
}
