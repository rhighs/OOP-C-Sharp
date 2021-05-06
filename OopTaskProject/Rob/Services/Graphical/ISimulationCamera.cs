using System;

namespace Monntalti
{
    interface ISimulationCamera
    {

        public Vector3f Location { get; } 

        public Vector3f Direction { get; }

        public void update();

        public void AttachToEntity(Entity entity);

        public void DetachEntity();

        private void followCurrentEntity();

    }
}
