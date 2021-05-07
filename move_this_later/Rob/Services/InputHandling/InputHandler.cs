using System;

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
            actions
                .Where(a => a.Key == actionName)
                .ForEach(a => a.Value());
        }

        public void AddAction(string actionName, Action action, Trigger inputTrigger)
        {
            input.AddListener(this, actionName);
            input.addMapping(actionName, inputTrigger);
            actions.put(actionName, action);
        }

    }
}
