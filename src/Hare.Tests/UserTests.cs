// Copyright 2014 Albert L. Hives
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

namespace Hare.Tests
{
    using NUnit.Framework;
    using Scenario;

    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Test()
        {
            var client = HareFactory.New(x =>
                                             {
                                                 x.ConnectTo("http://localhost:15672");
                                                 x.EnableLogging(y => y.Logger("HareDuLogger"));
                                             });
            var response = client.Factory<CreateNewUser>(x => x.Credentials("guest", "guest"))
                                 .New(x => x.User("haredu_2"))
                                 .With(x => x.Password("haredu"))
                                 .Having(x => x.Rights(s => s.Admin()))
                                 .On(x => x.VirtualHost("MyVirtualHostScenarioTest1"));

            Assert.IsTrue(response);
        }
    }
}