using System;
using System.Linq;
using System.Collections.Generic;
using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public class InputHandler : IInputHandler, ActionListener
    {
        private InputManager _input;

        private Dictionary<string, Action> actions;

        public InputHandler(InputManager input)
        {
           _input = input;
           actions = new Dictionary<string, Action>();
           input.AddListener(this);
        }

        public void OnAction(string actionName, bool isPressed, float tpf)
        {
            var filtered = actions.Where(a => a.Key == actionName);

            foreach(KeyValuePair<string, Action> entry in filtered)
            {
                entry.Value.Invoke();
            }
        }

        public void AddAction(string actionName, Action action, Trigger inputTrigger)
        {
            _input.AddListener(this, actionName);
            _input.AddMapping(actionName, inputTrigger);
            actions.Add(actionName, action);
        }

    }
}
