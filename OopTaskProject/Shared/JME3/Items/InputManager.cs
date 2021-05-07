using System.Collections.Generic;

namespace OopTaskProject.Shared.JME3.Items
{
    public class InputManager
    {
        public Dictionary<string, Trigger> mappings;

        private List<ActionListener> listeners;
        public InputManager()
        {
            mappings = new Dictionary<string, Trigger>();
            listeners = new List<ActionListener>();
        }

        public void AddListener(ActionListener listener)
        {
            listeners.Add(listener);
        }
        public void AddListener(ActionListener listener, string actionName)
        {
            //jme3 setting listener with actionName...
            listeners.Add(listener);
        }

        public void AddMapping(string key, Trigger trigger)
        {
           mappings.Add(key, trigger);
        }

    }
}

