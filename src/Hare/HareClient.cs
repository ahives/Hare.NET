namespace Hare
{
    using System;

    public interface HareClient
    {
        T Factory<T>(Action<LoginCredentials> userCredentials)
            where T : Scenario.Scenario;
    }
}