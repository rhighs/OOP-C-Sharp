using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public class Entity
    {
        public Vector3f Position { get; set; }
        public Entity()
        {
            Position = new Vector3f(0, 0, 0);
        }

    }
}