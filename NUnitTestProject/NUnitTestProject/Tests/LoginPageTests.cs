using NUnit.Framework;
using NUnitTestProject.Pages;

namespace NUnitTestProject.Tests
{
    public class LoginPageTests : BaseTest
    {
        private const string successAlertMessage = "You logged into a secure area!";
        private const string headingMessage = "Secure Area";

        [Test]
        public void CheckLoginProcess()
        {
            var loginPage = new LoginPage(driver);
            loginPage
                .SetUserName(LoginPage.UserName)
                .SetUserPassword(LoginPage.UserPassword)
                .ClickLogin()
                .GetHeadingTwoText(out var headingText)
                .GetAlertText(out var alertText);

            Assert.AreEqual(headingMessage, headingText);
            Assert.IsTrue(alertText.Contains(successAlertMessage));
        }
    }
}