using NSubstitute;
using NUnit.Framework;
using NUnitTestProject.AutomationLibrary.Database;

namespace NUnitTestProject.Tests
{
    public class MockTest
    {
        [Test]
        public void TestIfLogInformationIsNull()
        {
            var repository = Substitute.For<IRepository>();
            
            repository.Add(null).Returns(0);

            Assert.That(repository.Add(null), Is.EqualTo(0));
        }

        [Test]
        public void TestIfLogInformationIsNotNull()
        {
            var repository = Substitute.For<IRepository>();
            var logInformation = new LogInformation("111");
            
            repository.Add(logInformation).Returns(1);

            Assert.That(repository.Add(logInformation), Is.EqualTo(1));
        }
    }
}
