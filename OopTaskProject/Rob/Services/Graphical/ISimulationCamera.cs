using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Rob
{
    public interface ISimulationCamera
    {

        public Vector3F Location { get; } 

        public Vector3F Direction { get; }
        public Entity AttachedEntity { get; }

        public void update();

        public void AttachToEntity(Entity entity);

        public void DetachEntity();

    }
}
