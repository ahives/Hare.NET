namespace Hare.Internal
{
    using System;
    using Scenario;

    internal class CreateNewUserImpl :
        CreateNewUser
    {
        public SecurityPassword New(Action<NewUserCharacteristics> user)
        {
            throw new NotImplementedException();
        }
    }
}