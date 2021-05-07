using System;

namespace Montalti
{
    public class Physics : IPhysics
    {
        private PhysicsSpace physicsSpace;

        public Physics(BulletAppState bullet)
        {
            physicsSpace = bullet.GetPhysicsSpace();
        }

        public void AddToSpace(object obj)
        {
            physicsSpace.Add(obj);
        }
    }
}
