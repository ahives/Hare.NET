namespace Hare.Internal
{
    using System;

    internal class SecurityLevelBehaviorImpl :
        SecurityLevelBehavior
    {
        public void Admin()
        {
            ConfigurePermissions = ".*";
            WritePermissions = ".*";
            ReadPermissions = ".*";
        }
        public string ConfigurePermissions { get; set; }

        public string WritePermissions { get; set; }

        public string ReadPermissions { get; set; }
    }
}