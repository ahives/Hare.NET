namespace Hare.Internal
{
    using System;

    internal class VirtualHostTargetImpl :
        TargetBase,
        VirtualHostTarget
    {
        public void VirtualHost(string virtualHost)
        {
            Target = virtualHost;
        }
    }
}