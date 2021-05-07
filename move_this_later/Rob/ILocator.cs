using System;

namespace Montali {
    public interface ILocator {

        ISimpleApplication App { get; }

        IPhysics Physics { get; }

        IGraphics Graphics { get; }

        IInputHandler Input { get; }

        ISimulationCamera Cam { get; }

        IMainMap Map { get; }

        IAmbient Amibent { get; }

        Node GuiNode { get; }

    }
}
