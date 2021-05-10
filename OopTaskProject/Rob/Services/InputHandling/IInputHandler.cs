using System;
using OopTaskProject.Shared.JME3.Items;

namespace OopTaskProject.Rob
{
    public interface IInputHandler
    {
        public void AddAction(string actionName, Action action, Trigger inputTrigger);
    }
}

