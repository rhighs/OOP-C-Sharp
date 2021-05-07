using System;

namespace Montalti
{
    interface IInputHandler
    {
        public void AddAction(string actionName, Action action, Trigger inputTrigger);
    }
}

