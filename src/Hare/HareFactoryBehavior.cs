namespace Hare
{
    using System;

    public interface HareFactoryBehavior
    {
        /// <summary>
        /// Specifies RabbitMQ endpoint to which the client will establish an HTTP connection.
        /// </summary>
        /// <param name="url"></param>
        void ConnectTo(string url);

        /// <summary>
        /// Enables logging using the specified logger name found in the configuration file.
        /// </summary>
        /// <param name="logger"></param>
        void EnableLogging(Action<FactoryLogging> logger);

        /// <summary>
        /// Specifies the number of milliseconds to wait until the request will timeout.
        /// </summary>
        /// <param name="timeout"></param>
        void TimeoutAfter(TimeSpan timeout);
    }
}