using NUnit.Framework;
using TeamCityExampleWebApplication;

namespace TeamCityExampleWebApplication.Tests
{
    [TestFixture]
    public class Tests
    {
        private IBusinessLogic _businessLogic;

        [SetUp]
        public void Setup()
        {
            _businessLogic = new BusinessLogic();
        }

        [Test]
        public void Test1()
        {
            var name = _businessLogic.GetName();
            Assert.AreEqual(name, "Bob");
        }
    }
}