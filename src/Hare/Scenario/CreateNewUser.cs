namespace Hare.Scenario
{
    using System;

    public interface CreateNewUser :
        Scenario
    {
        SecurityPassword New(Action<NewUserCharacteristics> user);
    }

    public interface SecurityPassword
    {
        SecurityLevelAccess With(Action<Password> access);
    }

    public interface Password
    {
        void Password(string password);
    }

    public interface SecurityLevelAccess
    {
        Target Having(Action<SecurityLevelRole> role);
    }

    public interface SecurityLevelRole
    {
        void Rights(Action<SecurityLevelBehavior> behavior);
    }
}