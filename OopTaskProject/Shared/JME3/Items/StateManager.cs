using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class StateManager
    {
        public List<object> States { get; private set; }
        public StateManager()
        {
            States = new List<object>();
        }

        public void Attach(BulletAppState bullet)
        {
            States.Add(bullet);
        }
    }
}
