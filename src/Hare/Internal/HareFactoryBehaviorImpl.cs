namespace Hare.Internal
{
    using System;

    internal class HareFactoryBehaviorImpl :
        HareFactoryBehavior
    {
        public void ConnectTo(string url)
        {
            throw new NotImplementedException();
        }

        public void EnableLogging(Action<FactoryLogging> logger)
        {
            throw new NotImplementedException();
        }

        public void TimeoutAfter(TimeSpan timeout)
        {
            throw new NotImplementedException();
        }
    }
}