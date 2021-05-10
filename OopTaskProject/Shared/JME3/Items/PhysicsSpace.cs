using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class PhysicsSpace
    {
        public List<object> Objects { get; private set; }
        public PhysicsSpace()
        {
            Objects = new List<object>();
        }

        public void Add(object obj)
        {
            Objects.Add(obj);
        }
    }
}