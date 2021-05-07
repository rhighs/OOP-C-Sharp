using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class PhysicsSpace
    {
        private List<object> objects;
        public PhysicsSpace()
        {
           objects = new List<object>(); 
        }

        public void Add(object obj)
        {
            objects.Add(obj);
        }
    }
}