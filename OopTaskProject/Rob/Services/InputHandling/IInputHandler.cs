using System;
using OopTaskProject.Shared.JME3.Items;

namespace Montalti
{
    public interface IInputHandler
    {
        public void AddAction(string actionName, Action action, Trigger inputTrigger);
    }
}

