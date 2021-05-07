using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class StateManager
    {
        private List<object> states;
        public StateManager()
        {
            states = new List<object>();
        }

        public void Attach(BulletAppState bullet)
        {
            states.Add(bullet);
        }
    }
}
