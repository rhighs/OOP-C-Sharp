using System;

namespace OopTaskProject.Savi
{
    public class SystemTimeStuckManager : IStuckManager
    {
        private const int StuckTolerance = 10;

        private DateTime? _stuckStartTime;

        public bool IsStuck => _stuckStartTime.HasValue &&
                               (DateTime.Now - _stuckStartTime.Value > TimeSpan.FromSeconds(StuckTolerance));

        public void Toggle()
        {
            _stuckStartTime = DateTime.Now;
        }

        public void Reset()
        {
            _stuckStartTime = null;
        }
    }
}