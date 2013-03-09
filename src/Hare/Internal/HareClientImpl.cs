namespace Hare.Internal
{
    using System;
    using Scenario;

    internal partial class HareClientImpl :
        HareClient
    {
        public TScenario Factory<TScenario>(Action<LoginCredentials> userCredentials)
            where TScenario : Scenario
        {
            throw new NotImplementedException();
        }
    }
}