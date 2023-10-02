using System.Threading.Tasks;
using NUnit.Framework;

namespace Primary.Tests
{
    [TestFixture]
    public class LoginTests
    {
        [Test]
        public async Task AccessTokenCanBeObtainedByLoginInWithUserAndPassword()
        {
            var api = new Api(Api.DemoEndpoint);
            Assert.That(api.AccessToken, Is.Null);

            await api.Login(Api.DemoUsername, Api.DemoPassword);
            Assert.That(api.AccessToken, Is.Not.Null);
        }
    }
}
