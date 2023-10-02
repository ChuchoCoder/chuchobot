using System.Threading.Tasks;
using NUnit.Framework;
using Primary.Data.Orders;

namespace Primary.Tests.Builders
{
    [TestFixture]
    public class BuildTests
    {
        [OneTimeSetUp]
        public async Task Setup()
        {
            _api = await Build.AnApi();
        }

        #region API builder

        [Test]
        public async Task ApiIsBuiltLoggedIn()
        {
            var api = await Build.AnApi();
            Assert.That(api.AccessToken, Is.Not.Null.And.Not.Empty);
        }

        #endregion

        [Test]
        public async Task OrderCanBeBuildReadyToBeSubmitted()
        {
            // Submit an order
            var order = Build.AnOrder(_api);
            var orderId = await _api.SubmitOrder(Api.DemoAccount, order);
            Assert.That( orderId, Is.Not.EqualTo( default(ulong) ) );

            // Retrieve the order
            var retrievedOrder = await _api.GetOrderStatus(orderId);

            Assert.That(retrievedOrder.Status, 
                        Is.Not.EqualTo(Status.Rejected).And.Not.EqualTo(Status.Cancelled), 
                        retrievedOrder.StatusText
            );
        }

        private Api _api;
    }
}
