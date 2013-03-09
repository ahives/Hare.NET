﻿// Copyright 2014 Albert L. Hives
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

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