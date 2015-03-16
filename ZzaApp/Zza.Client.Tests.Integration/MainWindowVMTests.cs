
using NUnit.Framework;

namespace Zza.Client.Tests.Integration
{
    [TestFixture]
    public class MainWindowVmTests
    {
        [TestCase]
        public void Ctor_ServiceRunning_AllProducts()
        {
            var cut = new MainWindowVm();

            var allProductsCount = cut.Products.Count;

            Assert.That(15, Is.EqualTo(allProductsCount));
        }
    }
}
